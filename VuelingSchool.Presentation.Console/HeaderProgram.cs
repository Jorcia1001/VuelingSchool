using VuelingSchool.Common.Library.Models;
using VuelingSchool.DataAccess.Repository;

namespace VuelingSchool.Presentation.Console
{
    class HeaderProgram
    {
        static Student student;
        static StudentRepository studentRepository;
        static string opc;
        static bool isNumber;
        static int studentIdStatic;

        public void Options()
        {

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

                        AddNewStudnet(student, studentRepository);
                        break;
                    case "2":

                        ReadAllStudents(studentRepository);
                        System.Console.ReadKey();
                        break;
                    case "3":

                        if (SearchStudentById(student, studentRepository))
                        {
                            System.Console.WriteLine("Into data wich you want to update");
                            EditStudentById(student, studentRepository);

                        }
                        System.Console.ReadKey();

                        break;
                    case "4":
                        if (SearchStudentById(student, studentRepository))
                        {
                            
                            DeleteStudentById(student, studentRepository);
                            System.Console.WriteLine("Student Delete!!");
                            System.Console.ReadKey();

                        }
                        
                        break;

                    default:

                        break;
                }

            } while (!opc.Equals("5"));
        }

        public static void Menu()
        {
            System.Console.WriteLine("Welcome to Vueling School");
            System.Console.WriteLine("-----------------------");
            System.Console.WriteLine("-----  MENU  ----------");
            System.Console.WriteLine();
            System.Console.WriteLine("1.- Add New Student");
            System.Console.WriteLine("2.- Read All Student");
            System.Console.WriteLine("3.- Edit student by Id");
            System.Console.WriteLine("4.- Delete student by Id");
            System.Console.WriteLine("5.- Exit");
            System.Console.WriteLine("-----------------------");
        }

        public static void HeaderData()
        {
            System.Console.WriteLine(string.Format("{0,-38}|{1,-10}|{2,-15}|{3,-20}|{4,-10}",
                "GuidId", "StudenId", "Name", "Surname", "Birthday"));
        }

        public static void AddNewStudnet(Student student, StudentRepository studentRepository)
        {
            studentRepository = new StudentRepository();
            student = new Student();


            System.Console.Write("Student Id : ");
            student.StudenId = int.Parse(System.Console.ReadLine());
            System.Console.Write("Name       : ");
            student.Name = System.Console.ReadLine();
            System.Console.Write("Surname    : ");
            student.Surname = System.Console.ReadLine();
            System.Console.Write("Birthday   : ");
            student.Birthday = System.Console.ReadLine();

            if (studentRepository.isExistData())
            {
                if (studentRepository.FoundStudentById(student).StudenId != student.StudenId)
                {
                    studentRepository.AddStudent(student);
                    System.Console.WriteLine("Adding new Student!!");
                }
                else
                {
                    System.Console.WriteLine("Student already exist!!");
                }

            }
            else
            {
                studentRepository.AddStudent(student);
                System.Console.WriteLine("Adding new Student!!");
            }

            System.Console.ReadKey();

        }
        public static void ReadAllStudents(StudentRepository s)
        {

            s = new StudentRepository();
            if (s.isExistData())
            {
                HeaderData();
                s.ShowAllStudents();
            }
            else
            {
                System.Console.WriteLine("Don't exist data!!");
            }

        }
        public static void EditStudentById(Student student, StudentRepository studentRepository)
        {
            student = new Student();
            studentRepository = new StudentRepository();
            student.StudenId = studentIdStatic;
            studentRepository.UpdateStudentById(student);

            System.Console.Write("Student Id : ");
            student.StudenId = int.Parse(System.Console.ReadLine());
            System.Console.Write("Name       : ");
            student.Name = System.Console.ReadLine();
            System.Console.Write("Surname    : ");
            student.Surname = System.Console.ReadLine();
            System.Console.Write("Birthday   : ");
            student.Birthday = System.Console.ReadLine();
            studentRepository.AddStudent(student);
            System.Console.WriteLine("Student Update!!");



        }

        public static void DeleteStudentById(Student student, StudentRepository studentRepository)
        {
            student = new Student();
            studentRepository = new StudentRepository();
            student.StudenId = studentIdStatic;
            studentRepository.DeleteStudentById(student);


        }
        public static bool SearchStudentById(Student student, StudentRepository studentRepository)
        {
            student = new Student();
            studentRepository = new StudentRepository();
            string number = null;
            bool isFound = false;
            if (!studentRepository.isExistData())
            {
                System.Console.WriteLine("Don't exist data!!");
                return isFound;
            }
            else
            {
                do
                {
                    System.Console.Clear();
                    System.Console.Write("Insert number id of Student : ");
                    number = System.Console.ReadLine();
                    isNumber = int.TryParse(number, out int valor);

                } while (!isNumber);

                student.StudenId = int.Parse(number);
                studentIdStatic = student.StudenId;
                if (studentRepository.FoundStudentById(student) != student)
                {
                    System.Console.WriteLine("Student  not found!");
                    isFound = false;
                }
                else
                {

                    HeaderData();
                    System.Console.WriteLine(student.ToString());
                    System.Console.WriteLine("Student  found it!");
                    isFound = true;
                }

                System.Console.ReadKey();

                return isFound;
            }

        }
    }
}
