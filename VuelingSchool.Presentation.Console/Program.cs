using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingSchool.DataAccess.Repository;


namespace VuelingSchool.Presentation.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to Vueling School");
            StudentRepository sr = new StudentRepository();

            string opc;
            bool isNumber;

            do
            {
                
                do
                {
                    System.Console.Clear();
                    Menu();
                    opc =  System.Console.ReadLine();
                    /* Si es número correcto retornará true y saldrá
                       *  del Ciclo*/
                    isNumber = int.TryParse(opc, out int valor);
                } while (!isNumber);
                

                switch (opc)
                {
                    case "1":
                        System.Console.WriteLine("Insert the student data please");
                        sr.ResetDataStudent();
                        sr.GuidIdRepository = Guid.NewGuid();
                        System.Console.Write("StudentID : ");
                        sr.StudenIdRepository = System.Console.ReadLine();
                        System.Console.Write("Name      : ");
                        sr.NameRepository = System.Console.ReadLine();
                        System.Console.Write("Surname   : ");
                        sr.SurnameRepository = System.Console.ReadLine();
                        System.Console.Write("Birthday  : ");
                        sr.BirthdayRepository = System.Console.ReadLine();

                        sr.ReadDataStudent(sr.GuidIdRepository, sr.StudenIdRepository,
                            sr.NameRepository, sr.SurnameRepository, sr.BirthdayRepository);

                        System.Console.WriteLine("Adding new Student!!");
                        System.Console.ReadKey();
                        sr.AddStudent(sr.Student, sr.Filemanager);

                        break;

                    default:

                        sr.ResetDataStudent();
                        break;
                }

            } while (!opc.Equals("2"));          

        }

        static void Menu()
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
