using System;
using VuelingSchool.Common.Library.Models;
using VuelingSchool.Common.Library.Utils;

namespace VuelingSchool.DataAccess.Repository
{
    public class StudentRepository : IStudentRepository
    {

        public  Student AddStudent(Student s)
        {
            s.GuidId = Guid.NewGuid();
            Student student = Filemanager.AddContent(s);

            return student;
        }

        public  Student ReadAllStudents(Student s)
        {
            Student student = Filemanager.ReadContent(s);

            return student;
        }

        public Student ReadStudentById(Student s)
        {
            Student student = s;

            return student;
        }
    }
}
