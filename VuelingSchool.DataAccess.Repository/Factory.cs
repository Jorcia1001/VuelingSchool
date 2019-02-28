using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuelingSchool.DataAccess.Repository
{
    public class Factory : AbstractFactory
    {
        public int TypeFile { get; set; }

        public override AbstractRespository CreateNewRepository()
        {
            switch (TypeFile)
            {
                case 1:
                    return new FileRepository();
                case 2:
                    return new XMLRepository();
                case 3:
                    return new JsonRespository();

                default:
                    return new FileRepository();
            }

        }
    }
}
