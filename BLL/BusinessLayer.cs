using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;
using Models;
using Data_Access_Layer;

namespace BLL
{
    public class BusinessLayer
    {
        public static bool ActivateCard(StudentInfo student)
        {
            throw new NotImplementedException();
        }
        public static bool ActivateCard(int cardNumber)
        {
            try
            {
                DataAccess.SetAccountState("active");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static string ReserveFood(StudentInfo student,DailyReservedScheduleInfo[] foodSchedule)
        {
            if (!student.CardStatus)
                return "Card not activated.";
            using (TransactionScope ts = new TransactionScope())
            {
                try
                {
                    for (int i = 0; i < 7; i++)
                        DataAccess.InsertReservedFood(student, foodSchedule[i]);
                    ts.Complete();
                    return "ok";
                }
                catch (Exception)
                {
                    return "error";
                }
            }
        }
        public static string Charge(StudentInfo student, double amount)
        {
            using (TransactionScope ts=new TransactionScope())
            {
                try
                {
                    DataAccess.InsertCharge(student, amount);
                    ts.Complete();
                    return "ok";
                }
                catch
                {
                    return "error";
                }
            }
        }
        public static string ChangePassword(StudentInfo student,string newPassword)
        {
            if (newPassword.Length < 4)
                return "Password must be than 4 characters.";
            DataAccess.UpdatePassword(student, newPassword);
            return "ok";
        }
        public static string AddFood(FoodInfo food)
        {
            try
            {
                DataAccess.InsertFood(food);
                return "ok";
            }
            catch
            {
                throw new Exception();
            }
        }
        public static string AddSchedule(FoodSchedule foodSchedule)
        {
            try
            {
                DataAccess.UpdateFoodSchedule(foodSchedule);
                return "ok";
            }
            catch
            {
                throw new Exception();
            }
        }
        public static string ValidateStudentCard(string cardNumber, string password)
        {
            try
            {
                StudentInfo student = DataAccess.GetStudentInfo(cardNumber);
                if (student != null && student.Password == password)
                    return "ok";
                return "error";
            }
            catch
            {
                throw new Exception();
            }
        }
        public static string ValidateEmployeeCard(string cardNumber, string password)
        {
            try
            {
                EmployeeInfo employee = DataAccess.GetEmployeeInfo(cardNumber);
                if (employee != null && employee.Password == password)
                    return "ok";
                return "error";
            }
            catch
            {
                throw new Exception();
            }
        }
        public static StudentInfo GetStudentInfo(string studentNumber)
        {
            return DataAccess.GetStudentInfo(studentNumber);
        }
        public static double GetStudentBalance(string studentNumber)
        {
            return DataAccess.GetStudentBalance(studentNumber);
        }
        public static EmployeeInfo GetEmployeeInfo(string employeeInfo)
        {
            return DataAccess.GetEmployeeInfo(employeeInfo);
        }

        public static string GetBreakfast(string day, int meal)
        {
            switch (day)
            {
                case "saturday":
                    return DataAccess.GetBreakfastName(0, meal);
                case "sunday":
                    return DataAccess.GetBreakfastName(1, meal);
                case "monday":
                    return DataAccess.GetBreakfastName(2, meal);
                case "tuesday":
                    return DataAccess.GetBreakfastName(3, meal);
                case "wednesday":
                    return DataAccess.GetBreakfastName(4, meal);
                case "thursday":
                    return DataAccess.GetBreakfastName(5, meal);
                case "friday":
                    return DataAccess.GetBreakfastName(6, meal);
            }
            return "error";
        }

        public static string GetLunch(string day, int meal)
        {
            switch (day)
            {
                case "saturday":
                    return DataAccess.GetLunchName(0, meal);
                case "sunday":
                    return DataAccess.GetLunchName(1, meal);
                case "monday":
                    return DataAccess.GetLunchName(2, meal);
                case "tuesday":
                    return DataAccess.GetLunchName(3, meal);
                case "wednesday":
                    return DataAccess.GetLunchName(4, meal);
                case "thursday":
                    return DataAccess.GetLunchName(5, meal);
                case "friday":
                    return DataAccess.GetLunchName(6, meal);
            }
            return "error";
        }

        public static string GetDinner(string day, int meal)
        {
            switch (day)
            {
                case "saturday":
                    return DataAccess.GetDinnerName(0, meal);
                case "sunday":
                    return DataAccess.GetDinnerName(1, meal);
                case "monday":
                    return DataAccess.GetDinnerName(2, meal);
                case "tuesday":
                    return DataAccess.GetDinnerName(3, meal);
                case "wednesday":
                    return DataAccess.GetDinnerName(4, meal);
                case "thursday":
                    return DataAccess.GetDinnerName(5, meal);
                case "friday":
                    return DataAccess.GetDinnerName(6, meal);
            }
            return "error";
        }

        public static double GetFoodPrice(int value)
        {
            return DataAccess.GetFoodPrice(value);
        }

        public static List<int> GetNotActiveAccounts()
        {
            return DataAccess.GetNotActiveAccounts();
        }

        public static FoodSchedule GetSchdeule()
        {
            return DataAccess.GetFoodSchedule();

        }
    }
}
