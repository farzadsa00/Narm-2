using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;
using Models;

namespace BLL
{
    public class BusinessLayer
    {
        public static bool ActivateCard(StudentInfo student)
        {
            throw new NotImplementedException();
        }
        public static string ReserveFood(StudentInfo student, FoodInfo food,
            FoodScheduleInfo foodSchedule, ResturantInfo resturant)
        {
            string result = "";
            if (!student.CardStatus)
                return "Card not activated.";
            using (TransactionScope ts = new TransactionScope())
            {
                throw new NotImplementedException();
            }
            return result;
        }
        public static string Charge(StudentInfo student, double amount)
        {
            string result = "";
            using (TransactionScope ts=new TransactionScope())
            {
                throw new NotImplementedException();
            }
            return result;
        }
        public static bool RequestBalance(StudentInfo student)
        {
            using (TransactionScope ts = new TransactionScope())
            {
                throw new NotImplementedException();
            }
        }
        public static string ChangePassword(StudentInfo student,string newPassword)
        {
            if (newPassword.Length < 4)
                return "Password must be than 4 characters.";
            throw new NotImplementedException();
        }
        public static string AddFood(FoodInfo food)
        {
            throw new NotImplementedException();
        }
        public static string AddSchedule(FoodScheduleInfo foodSchedule)
        {
            throw new NotImplementedException();
        }
        public static string AddResturant(ResturantInfo resturant)
        {
            throw new NotImplementedException();
        }
        public static string ValidateStudentCard(string cardNumber, string password)
        {
            throw new NotImplementedException();
        }
        public static string ValidateEmployeeCard(string cardNumber, string password)
        {
            throw new NotImplementedException();
        }
        public static StudentInfo GetStudentInfo(string studentNumber)
        {
            throw new NotImplementedException();
        }
        public static double GetStudentBalance(string studentNumber)
        {
            throw new NotImplementedException();
        }
        public static EmployeeInfo GetEmployeeInfo(string employeeInfo)
        {
            throw new NotImplementedException();
        }
    }
}
