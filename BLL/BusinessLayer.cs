﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;
using Models;

namespace BLL
{
    public class BusinessLayer
    {
        public bool ActivateCard(StudentInfo student)
        {
            throw new NotImplementedException();
        }
        public string ReserveFood(StudentInfo student, FoodInfo food,
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
        public string Charge(StudentInfo student, double amount)
        {
            string result = "";
            using (TransactionScope ts=new TransactionScope())
            {
                throw new NotImplementedException();
            }
            return result;
        }
        public bool RequestBalance(StudentInfo student)
        {
            using (TransactionScope ts = new TransactionScope())
            {
                throw new NotImplementedException();
            }
        }
        public string ChangePassword(StudentInfo student,string newPassword)
        {
            throw new NotImplementedException();
        }

    }
}