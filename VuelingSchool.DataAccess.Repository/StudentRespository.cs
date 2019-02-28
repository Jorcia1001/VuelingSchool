using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VuelingSchool.DataAccess.Repository
{
    public class StudentRespository
    {
        public static  Factory myFactory = new Factory();
        public AbstractRespository myAbstractRespository = myFactory.CreateNewRepository();


        public StudentRespository(AbstractRespository myAbstractRespository)
        {
            this.myAbstractRespository = myAbstractRespository;
        }
    }
}
