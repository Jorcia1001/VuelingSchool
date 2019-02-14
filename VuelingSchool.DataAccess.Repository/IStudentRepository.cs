using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingSchool.Common.Library.Models;
using VuelingSchool.Common.Library.Utils;


namespace VuelingSchool.DataAccess.Repository
{
    public interface IStudentRepository
    {
        void AddStudent(Student s, Filemanager f);
        void ResetDataStudent();
        void ReadDataStudent(Guid guidId, string studenId, string name, string surname, string birthday);
        
    }
}
