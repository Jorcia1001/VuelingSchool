using System;
using System.IO;
using System.Configuration;
using VuelingSchool.Common.Library.Models;

namespace VuelingSchool.Common.Library.Utils
{
    public class Filemanager
    {
        private static readonly string repositoryPath;
        private static readonly string enviromentPath;
        private static readonly string localPath;
        private static bool isFoundStudent;

        static Filemanager()
        {
            repositoryPath = ConfigurationManager.AppSettings["localPath"];
            enviromentPath = Environment.GetEnvironmentVariable("localPath", EnvironmentVariableTarget.User);
            localPath = !string.IsNullOrWhiteSpace(enviromentPath) ? enviromentPath : repositoryPath;
        }

        public static Student ReadContent(Student s)
        {
            Student student = s;
            string line;
            string[] rows;
            isFoundStudent = false;
            try
            {

                using (StreamReader sr = File.OpenText(localPath))
                {
                
                    do
                    {
                        line = sr.ReadLine();


                        if (line!=null)
                        {
                           
                            rows = line.Split(",".ToCharArray());

                      

                            if (student.StudenId.Equals(int.Parse(rows.GetValue(1).ToString())))
                            {

                                student.GuidId = Guid.Parse(rows.GetValue(0).ToString());
                                student.StudenId = int.Parse(rows.GetValue(1).ToString());
                                student.Name = rows.GetValue(2).ToString();
                                student.Surname = rows.GetValue(3).ToString();
                                student.Birthday = rows.GetValue(4).ToString();
                                
                            }
                        }


                    } while (!sr.EndOfStream);
                    
                }
            }
            catch (UnauthorizedAccessException e)
            {
                System.Console.WriteLine(e.Message);
            }
            catch (ArgumentNullException e)
            {
                System.Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                System.Console.WriteLine(e.Message);
            }
            catch (PathTooLongException e)
            {
                System.Console.WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                System.Console.WriteLine(e.Message);
            }
            catch (FileNotFoundException e)
            {
                System.Console.WriteLine(e.Message);
            }
            catch (NotSupportedException e)
            {
                System.Console.WriteLine(e.Message);
            }
            

            return student;
        }

        public static Student AddContent(Student student)
        {
            try
            {
                using (StreamWriter sw = File.AppendText(localPath))
                {
                    sw.WriteLine(student.ToString());

                }
            }
            catch (UnauthorizedAccessException e)
            {
                System.Console.WriteLine(e.Message);
            }
            catch (ArgumentNullException e)
            {
                System.Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                System.Console.WriteLine(e.Message);
            }
            catch (PathTooLongException e)
            {
                System.Console.WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                System.Console.WriteLine(e.Message);
            }
            catch (NotSupportedException e)
            {
                System.Console.WriteLine(e.Message);
            }
            return student;

        }
    }
}