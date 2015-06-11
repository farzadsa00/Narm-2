using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class ResturantInfo
    {
        public int ResturantNumber { get; set; }
        public string ResturantName { get; set; }

        public ResturantInfo(int resturantNumber, string resturantName)
        {
            ResturantNumber = resturantNumber;
            ResturantName = resturantName;
        }
    }
}
