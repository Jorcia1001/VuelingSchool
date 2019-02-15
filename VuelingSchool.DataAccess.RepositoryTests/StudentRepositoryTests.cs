using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VuelingSchool.Common.Library.Models;
using VuelingSchool.DataAccess.Repository;

namespace VuelingSchool.DataAccess.Repository.Tests
{
    [TestClass()]
    public class StudentRepositoryTests
    {
        IStudentRepository iStudentRepository = new StudentRepository();
         
        [DataTestMethod]
        public void AddStudentTest(Student entrada, Student salida)
        {
            Guid guidId = Guid.NewGuid();
            entrada = new Student("1", "Jhon", "Perez","01/02/1995",guidId);
            salida = new Student("1", "Jhon", "Perez", "01/02/1995", guidId);

            Assert.IsTrue(iStudentRepository.AddStudent(entrada) == salida);
        }
    }
}