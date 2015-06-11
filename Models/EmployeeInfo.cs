using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class EmployeeInfo
    {
        public int EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }
        public string Password { get; set; }

        public EmployeeInfo(int number, string fname, string lname, string id, string password)
        {
            EmployeeNumber = number;
            FirstName = fname;
            LastName = lname;
            Id = id;
            Password = password;
        }
    }
}
