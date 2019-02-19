using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuelingSchool.DataAccess.Repository
{
    class JsonFileRespository : FileRespositoryAbstractFactory
    {
        public override string Description()
        {
            return  "Creando Json";
        }
    }
}
