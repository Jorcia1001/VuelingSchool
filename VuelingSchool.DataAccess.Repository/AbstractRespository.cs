using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingSchool.Common.Library.Models;

namespace VuelingSchool.DataAccess.Repository
{
    public abstract class AbstractRespository
    {
        public abstract Student Add(Student student);

        public abstract List<Student> GetAll();

        public abstract Student GetById(Student student);

        public abstract Student Update(Student student);

        public abstract bool Delete(Student student);
    }
}
