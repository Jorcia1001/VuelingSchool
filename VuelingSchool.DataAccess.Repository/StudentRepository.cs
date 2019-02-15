using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingSchool;
using VuelingSchool.Common.Library.Models;
using VuelingSchool.Common.Library.Utils;

namespace VuelingSchool.DataAccess.Repository
{
    public class StudentRepository : IStudentRepository
    {

        public Student AddStudent(Student s)
        {
            try
            {
                Student student = s;
                student.guidId = Guid.NewGuid();
                student.guidId = s.guidId;
                student.studenId = s.studenId;
                student.name = s.name;
                student.surname = s.surname;
                student.birthday = s.birthday;
                return student;
            }
            catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                throw;
            }
        }
    }
}
