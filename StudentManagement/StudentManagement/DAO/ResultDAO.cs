using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DAO
{
    public class ResultDAO
    {
        private Student_ManagementContext context = new Student_ManagementContext();
        public void InsertMark(int StudentCode, string SubjectCode, int mark)
        {
            Result result = new Result { StudentCode = StudentCode, SubjectCode = SubjectCode, Mark = mark };
            context.Add(result);
            context.SaveChanges();
        }
        public void UpdateMark(int StudentCode, string SubjectCode, int mark)
        {
            var existResult = CheckResultExists(StudentCode, SubjectCode);
            context.Remove(existResult);
            Result result = new Result { StudentCode = StudentCode, SubjectCode = SubjectCode, Mark = mark };
            context.Add(result);
            context.SaveChanges();
        }
        public void DeleteResultBySubjectCode(string subjectCode)
        {
           var result = context.Results.FirstOrDefault(r => r.SubjectCode.Equals(subjectCode));
            context.Results.Remove(result);
            context.SaveChanges();
        }
        public void UpdateResultBySubjectCode(string subjectCode)
        {
            var result = context.Results.FirstOrDefault(r => r.SubjectCode.Equals(subjectCode));
            context.Results.Update(result);
            context.SaveChanges();
        }
        public Result CheckResultExists(int StudentCode, string SubjectCode)
        {
            return context.Results.FirstOrDefault(r => r.StudentCode == StudentCode && r.SubjectCode.Equals(SubjectCode));
        }
        public List<Result> GetMarkByStudentCode(int StudentCode)
        {
           return context.Results.Where(r => r.StudentCode == StudentCode).ToList();
        }
    }
}
