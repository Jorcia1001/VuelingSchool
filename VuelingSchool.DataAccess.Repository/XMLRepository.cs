using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using VuelingSchool.Common.Library.Models;

namespace VuelingSchool.DataAccess.Repository
{
    public class XMLRepository : AbstractRespository

    {
        private static readonly string repositoryPath;
        private static readonly string enviromentPath;
        private static readonly string localPathXML;


        static XMLRepository()
        {
            repositoryPath = ConfigurationManager.AppSettings["localPathXML"];
            enviromentPath = Environment.GetEnvironmentVariable("localPathXML", EnvironmentVariableTarget.User);
            localPathXML = !string.IsNullOrWhiteSpace(enviromentPath) ? enviromentPath : repositoryPath;

        }

        public override Student Add(Student student)
        {

            List<Student> listStudents = null;

            try
            {
                listStudents = GetAll();


                listStudents.Add(student);
                XmlSerializer writer = new XmlSerializer(typeof(List<Student>), new XmlRootAttribute("Students"));

                using (FileStream file = File.OpenWrite(localPathXML))
                {
                    writer.Serialize(file, listStudents);

                }
            }
            catch (UnauthorizedAccessException e)
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
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            return student;
        }

        public override bool Delete(Student student)
        {
            throw new NotImplementedException();
        }

        public override List<Student> GetAll()
        {

            List<Student> dezerializedList = new List<Student>();
            try
            {

                using (FileStream stream = File.OpenRead(localPathXML))
                {

                    XmlSerializer serializer = new XmlSerializer(typeof(List<Student>), new XmlRootAttribute("Students"));
                    dezerializedList = (List<Student>)serializer.Deserialize(stream);
                    return dezerializedList;
                }
            }
            catch (UnauthorizedAccessException e)
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
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            return dezerializedList;
        }

        public override Student GetById(Student student)
        {
            throw new NotImplementedException();
        }

        public override Student Update(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
