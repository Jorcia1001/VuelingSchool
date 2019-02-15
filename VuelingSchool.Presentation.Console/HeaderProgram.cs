using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingSchool.Common.Library.Models;
using VuelingSchool.Common.Library.Utils;
using VuelingSchool.DataAccess.Repository;

namespace VuelingSchool.Presentation.Console
{
    class HeaderProgram
    {
        Student student;
        Filemanager filemanager;
        StudentRepository studentRepository;
        public HeaderProgram()
        {
            student = new Student();
            filemanager = new Filemanager(student.ToString());
            studentRepository = new StudentRepository();

        }

        public void Options()
        {
            
            string opc;
            bool isNumber;
            System.Console.WriteLine("Welcome to Vueling School");
            do
            {

                do
                {
                    System.Console.Clear();
                    Menu();
                    opc = System.Console.ReadLine();
                    isNumber = int.TryParse(opc, out int valor);
                } while (!isNumber);


                switch (opc)
                {
                    case "1":
                        System.Console.Write("Student Id : ");
                        student.studenId =  System.Console.ReadLine();
                        System.Console.Write("Name       : ");
                        student.name = System.Console.ReadLine();
                        System.Console.Write("Surname    : ");
                        student.surname = System.Console.ReadLine();
                        System.Console.Write("Birthday   : ");
                        student.birthday = System.Console.ReadLine();
                        System.Console.WriteLine("Adding new Student!!");
                        studentRepository.AddStudent(student);
                        filemanager.OnExist();
                        filemanager.AddContent(student.ToString());
                        System.Console.ReadKey();

                        break;

                    default:


                        break;
                }

            } while (!opc.Equals("2"));
        }



        public void Menu()
        {
            System.Console.WriteLine("--------------------");
            System.Console.WriteLine("-----  MENU  -------");
            System.Console.WriteLine();
            System.Console.WriteLine("1.- Add New Student");
            System.Console.WriteLine("2.- Exit");
            System.Console.WriteLine("--------------------");
        }
    }
}
