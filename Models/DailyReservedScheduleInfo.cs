using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class DailyReservedScheduleInfo
    {
        public int StudentNumber { get; set; }
        public DateTime ReserveDate { get; set; }
        public int BreakfastNumber { get; set; }
        public int LunchNumber { get; set; }
        public int DinnerNumber { get; set; }
        public int BreakfastResturantNumber { get; set; }
        public int LunchResturantNumber { get; set; }
        public int DinnerResturantNumber { get; set; }

        public DailyReservedScheduleInfo(int studentNumber, DateTime reserveDate, int breakfastNumber, 
            int lunchNumber, int dinnerNumber, int breakfastResturantNumber, int lunchResturantNumber, 
            int dinnerResturantNumber)
        {
            StudentNumber = studentNumber;
            ReserveDate = reserveDate;
            BreakfastNumber = breakfastNumber;
            LunchNumber = lunchNumber;
            DinnerNumber = dinnerNumber;
            BreakfastResturantNumber = breakfastResturantNumber;
            LunchResturantNumber = lunchResturantNumber;
            DinnerResturantNumber = dinnerResturantNumber;
        }
    }
}
