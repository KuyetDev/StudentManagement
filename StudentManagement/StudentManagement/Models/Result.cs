using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagement.Models
{
    public partial class Result
    {
        public int StudentCode { get; set; }
        public string SubjectCode { get; set; }
        public int Mark { get; set; }

        public virtual Student StudentCodeNavigation { get; set; }
        public virtual Subject SubjectCodeNavigation { get; set; }
    }
}
