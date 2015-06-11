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
        //use case
        public string ReserveFood(StudentInfo student, FoodInfo food,
            FoodScheduleInfo foodSchedule, ResturantInfo resturant)
        {
            using (TransactionScope ts = new TransactionScope())
            {
                throw new NotImplementedException();
            }
        }


    }
}
