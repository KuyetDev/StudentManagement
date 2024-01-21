using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagement.Models
{
    public partial class Student
    {
        public Student()
        {
            Results = new HashSet<Result>();
        }

        public int StudentCode { get; set; }
        public string StudentName { get; set; }
        public DateTime Dob { get; set; }
        public bool Gender { get; set; }
        public string Address { get; set; }
        public int PhoneNum { get; set; }
        public string MajorCode { get; set; }

        public virtual Major MajorCodeNavigation { get; set; }
        public virtual ICollection<Result> Results { get; set; }
    }
}
