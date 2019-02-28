using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingSchool.Common.Library.Models;

namespace VuelingSchool.DataAccess.Repository
{
    public class JsonRespository : AbstractRespository
    {
        private static readonly string repositoryPath;
        private static readonly string enviromentPath;
        private static readonly string localPathXML;

        static JsonRespository()
        {
            repositoryPath = ConfigurationManager.AppSettings["localPathJson"];
            enviromentPath = Environment.GetEnvironmentVariable("localPathJson", EnvironmentVariableTarget.User);
            localPathXML = !string.IsNullOrWhiteSpace(enviromentPath) ? enviromentPath : repositoryPath;

        }

        public override Student Add(Student student)
        {
            throw new NotImplementedException();
        }

        public override List<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public override Student GetById(Student student)
        {
            throw new NotImplementedException();
        }

        public override Student Update(Student student)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(Student student)
        {
            throw new NotImplementedException();
        }
    }

       
    }
}
