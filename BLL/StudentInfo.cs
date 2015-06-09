using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    class StudentInfo
    {
        public string StudentNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }
        public int EntryYear { get; set; }
        public bool DormitoryStatus { get; set; }
        public bool CardStatus { get; set; }
        public string Password { get; set; }
    }
}
