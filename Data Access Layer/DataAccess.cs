using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;

namespace Data_Access_Layer
{
    public class DataAccess
    {
        public readonly static string Connection = "server=(local);initial catalog=FRS;integrated security=true";

        public static void InsertCharge(StudentInfo student, double amount)
        {
            throw new NotImplementedException();
        }
        public static void SetAccountState(string active)
        {
            throw new NotImplementedException();
        }
        public static void InsertReservedFood(StudentInfo student, DailyReservedScheduleInfo dailyReservedScheduleInfo)
        {
            throw new NotImplementedException();
        }
        public static void UpdatePassword(StudentInfo student, string newPassword)
        {
            throw new NotImplementedException();
        }
        public static void InsertFood(FoodInfo food)
        {
            throw new NotImplementedException();
        }
        public static void UpdateFoodSchedule(FoodSchedule foodSchedule)
        {
            throw new NotImplementedException();
        }
        public static StudentInfo GetStudentInfo(string cardNumber)
        {
            throw new NotImplementedException();
        }
        public static EmployeeInfo GetEmployeeInfo(string cardNumber)
        {
            throw new NotImplementedException();
        }
        public static double GetStudentBalance(string studentNumber)
        {
            throw new NotImplementedException();
        }

        public static string GetBreakfastName(int p0, int meal)
        {
            throw new NotImplementedException();
        }

        public static string GetLunchName(int p0, int meal)
        {
            throw new NotImplementedException();
        }

        public static string GetDinnerName(int p0, int meal)
        {
            throw new NotImplementedException();
        }

        public static double GetFoodPrice(int value)
        {
            throw new NotImplementedException();
        }

        public static List<int> GetNotActiveAccounts()
        {
            throw new NotImplementedException();
        }

        public static FoodSchedule GetFoodSchedule()
        {
            throw new NotImplementedException();
        }
    }
}
