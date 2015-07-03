using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class DailyReservedScheduleInfo
    {
        public int StudentNumber { get; set; }
        public int BreakfastNumber { get; set; }
        public int LunchNumber { get; set; }
        public int DinnerNumber { get; set; }

        public DailyReservedScheduleInfo()
        {
            
        }
        public DailyReservedScheduleInfo(int studentNumber, int breakfastNumber, int lunchNumber,
            int dinnerNumber)
        {
            StudentNumber = studentNumber;
            BreakfastNumber = breakfastNumber;
            LunchNumber = lunchNumber;
            DinnerNumber = dinnerNumber;
        }
    }
}
