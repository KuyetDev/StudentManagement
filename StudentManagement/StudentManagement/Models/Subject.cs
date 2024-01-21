using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagement.Models
{
    public partial class Subject
    {
        public Subject()
        {
            Results = new HashSet<Result>();
        }

        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public int NumberOfSlot { get; set; }

        public virtual ICollection<Result> Results { get; set; }
    }
}
