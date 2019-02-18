using System;
using System.IO;
using System.Configuration;
using VuelingSchool.Common.Library.Models;
using System.Collections.Generic;

namespace VuelingSchool.Common.Library.Utils
{
    public class Filemanager
    {
        private static readonly string repositoryPath;
        private static readonly string enviromentPath;
        private static readonly string localPath;

        static Filemanager()
        {
            repositoryPath = ConfigurationManager.AppSettings["localPath"];
            enviromentPath = Environment.GetEnvironmentVariable("localPath", EnvironmentVariableTarget.User);
            localPath = !string.IsNullOrWhiteSpace(enviromentPath) ? enviromentPath : repositoryPath;
        }

        public static int SaveLineStudentFound(Student s)
        {
            int indexOfLine = 0;
            int nLines = 0;
            Student student = s;
            string line = null;
            string[] rows = null;
            try
            {

                using (StreamReader sr = File.OpenText(localPath))
                {
                    do
                    {
                        line = sr.ReadLine();
                        rows = line.Split(",".ToCharArray());
                        if (line != null)
                        {
                            if (student.StudenId.Equals(int.Parse(rows.GetValue(1).ToString())))
                            {
                                indexOfLine = nLines;
                              
                            }
                        }
                        nLines++;
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
            return indexOfLine;
        }

        public static Student FoundStudenById(Student s)
        {
            Student student = null;
            string line = null;
            string[] rows = null;
            try
            {

                using (StreamReader sr = File.OpenText(localPath))
                {
                    do
                    {
                        line = sr.ReadLine();
                        rows = line.Split(",".ToCharArray());
                        if (line != null)
                        {
                            if (s.StudenId.Equals(int.Parse(rows.GetValue(1).ToString())))
                            {
                                student = s;
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

        public static void DeleteLine(int line)
        {
            var file = new List<string>(System.IO.File.ReadAllLines(localPath));
            file.RemoveAt(line);
            File.WriteAllLines(localPath, file.ToArray());

        }

        public static void ReadAllContent()
        {
            try
            {
                using (StreamReader sr = File.OpenText(localPath))
                {
                    do
                    {
                        Console.WriteLine(sr.ReadLine());
                    } while (!sr.EndOfStream);
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (PathTooLongException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (NotSupportedException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OutOfMemoryException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static bool IsExist()
        {
            bool isExist = File.Exists(localPath);
            return isExist;
        }
    }
}