using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingSchool.Common.Library.Models;


namespace VuelingSchool.DataAccess.Repository
{
    public interface IStudentRepository
    {
        Student AddStudent(Student s);
 
    }
}
