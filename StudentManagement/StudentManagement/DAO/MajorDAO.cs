using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Models;
namespace StudentManagement.DAO
{
    public class MajorDAO
    {
        private Student_ManagementContext context = new Student_ManagementContext();
        public List<Major> GetListMajor()
        {
            return context.Majors.ToList();
        }
        public Major GetMajorNameByCode(string code)
        {
            return context.Majors.FirstOrDefault(m => m.MajorCode.Equals(code));
        }
    }
}
