using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingSchool;
using VuelingSchool.Common.Library.Models;
using VuelingSchool.Common.Library.Utils;

namespace VuelingSchool.DataAccess.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private string studenIdRepository;
        private string nameRepository;
        private string surnameRepository;
        private string birthdayRepository;
        private Guid guidIdRepository;
        private Student student;
        private Filemanager filemanager;


        public StudentRepository()
        {
            student = new Student();
            filemanager = new Filemanager();
        }

        public string StudenIdRepository { get => studenIdRepository; set => studenIdRepository = value; }
        public string NameRepository { get => nameRepository; set => nameRepository = value; }
        public string SurnameRepository { get => surnameRepository; set => surnameRepository = value; }
        public string BirthdayRepository { get => birthdayRepository; set => birthdayRepository = value; }
        public Guid GuidIdRepository { get => guidIdRepository; set => guidIdRepository = value; }
        public Student Student { get => student; set => student = value; }
        public Filemanager Filemanager { get => filemanager; set => filemanager = value; }

        public void AddStudent(Student s, Filemanager f)
        {   
            s.GuidId = GuidIdRepository;
            s.StudenId = StudenIdRepository;
            s.Name = NameRepository;
            s.Surname = surnameRepository;
            s.Birthday = BirthdayRepository;

            try
            {
                f.SaveTxt(s.ToString());
            }
            catch(FileNotFoundException e)
            {
                System.Console.WriteLine(e.Message);
                throw;
            }
           

        }

       
        public void ReadDataStudent(Guid guidId, string studenId, string name, string surname, string birthday)
        {
            GuidIdRepository = guidId;
            StudenIdRepository = studenId;
            NameRepository = name;
            SurnameRepository = surname;
            BirthdayRepository = birthday;

        }

        public void ResetDataStudent()
        {
            GuidIdRepository = Guid.Empty;
            StudenIdRepository = null;
            NameRepository = null;
            SurnameRepository = null;
            BirthdayRepository = null;
            
        }
    }
}
