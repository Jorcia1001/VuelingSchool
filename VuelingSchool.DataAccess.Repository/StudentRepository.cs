using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingSchool;
using VuelingSchool.Common.Library.Models;

namespace VuelingSchool.DataAccess.Repository
{
    public class StudentRepository : IStudentRepository
    {
        public void PrintMenu()
        {
            
        }


        public void WriteFile(int studentId, string name, string surname, string birthday)
        {
            Student s1 = new Student(studentId,name, surname, birthday);

        }
    }
}
