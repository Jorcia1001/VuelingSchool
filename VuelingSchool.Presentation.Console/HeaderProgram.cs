using VuelingSchool.Common.Library.Models;
using VuelingSchool.DataAccess.Repository;

namespace VuelingSchool.Presentation.Console
{
    class HeaderProgram
    {
        Student student;
        StudentRepository studentRepository;

        public void Options()
        {

            string opc, number;
            bool isNumber, isCancel, isCorrect;



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
                        AddNewStudnet(student,studentRepository);
                        break;
                    case "2":
                        student = new Student();
                        studentRepository = new StudentRepository();



                        do
                        {
                            isCancel = false;
                            isCorrect = false;
                            number = null;
                            System.Console.Clear();
                            System.Console.Write("Insert number id of Student : ");

                            number = System.Console.ReadLine();
                            isNumber = int.TryParse(number, out int valor);

                            if (!isNumber)
                            {

                                do
                                {
                                    System.Console.Clear();
                                    System.Console.WriteLine("ID Student is only numbers!!");
                                    System.Console.WriteLine("¿Do you wanna try again?");
                                    opc = System.Console.ReadLine();
                                    switch (opc)
                                    {
                                        case "y":
                                        case "Y":
                                            isCancel = false;
                                            isCorrect = true;
                                            break;
                                        case "n":
                                        case "N":
                                            isCancel = true;
                                            isCorrect = true;
                                            number = "0";
                                            break;
                                        default:
                                            isCorrect = false;
                                            break;

                                    }
                                } while (!isCorrect);

                            }
                            else
                            {
                                isCancel = true;
                               
                            }
                        } while ((!isCancel)&&(!isNumber));

                        student.StudenId = int.Parse(number);
                        if (student.StudenId.Equals(0))
                        {
                            System.Console.WriteLine(student.StudenId.ToString());
                            System.Console.WriteLine("Student  not found!");
                        }
                        else
                        {
                            HeaderDates(studentRepository.ReadStudentById(student));
                            
                        }
                       
                        System.Console.ReadKey();
                        break;

                    default:

                        break;
                }

            } while (!opc.Equals("3"));
        }



        public static void Menu()
        {
            System.Console.WriteLine("-----------------------");
            System.Console.WriteLine("-----  MENU  ----------");
            System.Console.WriteLine();
            System.Console.WriteLine("1.- Add New Student");
            System.Console.WriteLine("2.- Search studen by Id");
            System.Console.WriteLine("2.- Search studen by Id");
            System.Console.WriteLine("3.- Exit");
            System.Console.WriteLine("-----------------------");
        }

        public static void HeaderDates(Student s)
        {
            System.Console.WriteLine(string.Format("{0,-38},{1,-10},{2,-15},{3,-20},{4,-10}",
                "GuidId", "StudenId", "Name", "Surname", "Birthday"));
            System.Console.WriteLine(s.ToString());
        }

        public static void AddNewStudnet(Student student,StudentRepository studentRepository)
        {
            studentRepository = new StudentRepository();

            System.Console.Write("Student Id : ");
            student.StudenId = int.Parse(System.Console.ReadLine());
            System.Console.Write("Name       : ");
            student.Name = System.Console.ReadLine();
            System.Console.Write("Surname    : ");
            student.Surname = System.Console.ReadLine();
            System.Console.Write("Birthday   : ");
            student.Birthday = System.Console.ReadLine();
            System.Console.WriteLine("Adding new Student!!");
            studentRepository.AddStudent(student);
            System.Console.ReadKey();

            

        }


    }
}
