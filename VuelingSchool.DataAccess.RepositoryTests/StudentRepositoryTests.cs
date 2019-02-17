using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VuelingSchool.Common.Library.Models;

namespace VuelingSchool.DataAccess.Repository.Tests
{
    [TestClass()]
    public class StudentRepositoryTests
    {
        readonly IStudentRepository iStudentRepository = new StudentRepository();

        [DataRow(48077877, "Jordy", "Garcia Intriago", "20/03/1995")]
        [DataTestMethod]
        public void AddStudentRepository(int studentId, string name, string surname, string birthday)
        {
          
            Student entrada = new Student(studentId, name, surname, birthday);
            Student salida = iStudentRepository.AddStudent(entrada);

            Assert.AreEqual(entrada, salida);
        }

        [DataRow(1,1)]
        [DataTestMethod]
        public void ReadStudentByIdRepository(int studentIdIn,int studentIdOut)
        {

            Student entrada = new Student
            {
                StudenId = studentIdIn
            };

            Student salida = new Student
            {
                StudenId = studentIdOut
            };
            
            
            System.Console.WriteLine("Entrada: "+entrada.ToString());
            System.Console.WriteLine("Salida:  "+salida.ToString());

            Assert.AreEqual(entrada, salida);
        }
    }
}