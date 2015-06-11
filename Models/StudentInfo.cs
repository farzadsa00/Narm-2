using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class StudentInfo
    {
        public int StudentNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }
        public int EntryYear { get; set; }
        public bool DormitoryStatus { get; set; }
        public bool CardStatus { get; set; }
        public string Password { get; set; }

        public StudentInfo(int studentNumber, string firstName, string lastName, string id, int entryYear, bool dormitoryStatus, bool cardStatus, string password)
        {
            StudentNumber = studentNumber;
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            EntryYear = entryYear;
            DormitoryStatus = dormitoryStatus;
            CardStatus = cardStatus;
            Password = password;
        }
    }
}
