using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class FoodSchedule
    {
        public List<string> Breakfasts;
        public List<string> Lunches;
        public List<string> Dinners;

        public List<int> BreakfastsPrices;
        public List<int> LunchessPrices;
        public List<int> DinnersPrices;
        public FoodSchedule()
        {
            Breakfasts = new List<string>();
            Lunches = new List<string>();
            Dinners = new List<string>();
            BreakfastsPrices = new List<int>();
            LunchessPrices = new List<int>();
            DinnersPrices = new List<int>();
        }
    }
}
