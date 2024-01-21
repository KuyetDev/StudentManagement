using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagement.Models
{
    public partial class Major
    {
        public Major()
        {
            Students = new HashSet<Student>();
        }

        public string MajorCode { get; set; }
        public string MajorName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
