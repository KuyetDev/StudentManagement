using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DAO
{
    public class SubjectDAO
    {
        private Student_ManagementContext context = new Student_ManagementContext();
        public List<Subject> GetListSubject()
        {
            return context.Subjects.ToList();
        }
        public Subject GetSubjectNameByCode(string code)
        {
            return context.Subjects.FirstOrDefault(m => m.SubjectCode.Equals(code));
        }

        public void AddSubject(string subjectCode, string subjectName, int numberOfSlot)
        {
            Subject subject = new Subject { SubjectCode = subjectCode, SubjectName = subjectCode, NumberOfSlot = numberOfSlot };
            context.Subjects.Add(subject);
            context.SaveChanges();
        }
        public void UpdateSubject(string subjectCode, string subjectName, int numberOfSlot)
        {
            var existSubject = CheckSubjectExists(subjectCode);
            context.Subjects.Remove(existSubject);
            Subject subject = new Subject { SubjectCode = subjectCode, SubjectName = subjectName, NumberOfSlot = numberOfSlot };
            context.Subjects.Add(subject);
            context.SaveChanges();
        }
        public void DeleteSubject(string subjectCode)
        {
            var existSubject = CheckSubjectExists(subjectCode);
            context.Subjects.Remove(existSubject);
            context.SaveChanges();
        }
        public Subject CheckSubjectExists(string subjectCode)
        {
            return context.Subjects.FirstOrDefault(r => r.SubjectCode.Equals(subjectCode));
        }
    }
}
