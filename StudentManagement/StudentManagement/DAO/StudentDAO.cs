using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DAO
{
    public class StudentDAO
    {
        private Student_ManagementContext context = new Student_ManagementContext();
        public List<Student> GetListStudentByMajorCode(string code)
        {
            return context.Students.Where(s => s.MajorCode.Equals(code)).ToList();
        }
        public Student GetStudentByID(int id)
        {
            return context.Students.FirstOrDefault(s => s.StudentCode == id);
        }
        public List<Student> GetAllStudents()
        {
            return context.Students.ToList();
        }
    }
}
