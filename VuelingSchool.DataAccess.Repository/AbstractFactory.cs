using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuelingSchool.DataAccess.Repository
{
    public abstract class AbstractFactory
    {
        public abstract AbstractRespository CreateNewRepository();
    }
}
