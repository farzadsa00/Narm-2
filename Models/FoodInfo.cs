using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class FoodInfo
    {
        public int FoodNumber { get; set; }
        public string FoodName { get; set; }
        public double Price { get; set; }

        public FoodInfo(int foodNumber, string foodName, double price)
        {
            FoodNumber = foodNumber;
            FoodName = foodName;
            Price = price;
        }
    }
}
