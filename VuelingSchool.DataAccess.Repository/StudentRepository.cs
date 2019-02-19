using System;
using VuelingSchool.Common.Library.Models;
using VuelingSchool.Common.Library.Utils;

namespace VuelingSchool.DataAccess.Repository
{
    public class StudentRepository : IStudentRepository
    {
        protected string tipo;
        public StudentRepository()
        {

        }
        public StudentRepository(string t)
        {
            this.tipo = t;
        }
        public  bool IsExistData()
        {
            return Filemanager.IsExist();
        }
        public Student AddStudent(Student s)
        {
            
            s.GuidId = Guid.NewGuid();
            Student student = Filemanager.AddContent(s);

            return student;
        }

        public void DeleteStudentById(Student s)
        {
            
            int lineIndexId = 0;
            lineIndexId = Filemanager.SaveLineStudentFound(s);
            if (lineIndexId != 0)
            {
                Filemanager.DeleteLine(lineIndexId);

            }
        }

        public void ShowAllStudents()
        {
            Filemanager.ReadAllContent();
        }

        public Student FoundStudentById(Student s)
        {
            Student student = Filemanager.FoundStudenById(s);

            return student;
        }


        public void UpdateStudentById(Student s)
        {
            
            int lineIndexId = 0;

          
                lineIndexId = Filemanager.SaveLineStudentFound(s);
                if (lineIndexId != 0)
                {
                Filemanager.DeleteLine(lineIndexId);
                   
                }
            

        }

        public FileRespositoryAbstractFactory CreateFile()
        {
            if (tipo.Equals("XML"))
            {
                return new XmlFileRepository();
            }
            else if (tipo.Equals("Json"))
            {
                return new XmlFileRepository();
            }
            else
            {
                return new TxtFileRepository();
            }
        }
    }
}
