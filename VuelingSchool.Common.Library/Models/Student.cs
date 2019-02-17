using System;
using System.Collections.Generic;

namespace VuelingSchool.Common.Library.Models
{

    public class Student
    {
        public int StudenId { set; get; }
        public string Name { set; get; }
        public string Surname { set; get; }
        public string Birthday { set; get; }
        public Guid GuidId { set; get; }

        public Student()
        {
           
        }

        public Student(int studenId, string name, string surname, string birthday)
        {

            this.GuidId = Guid.NewGuid();
            this.StudenId = studenId;
            this.Name = name;
            this.Surname = surname;
            this.Birthday = birthday;

        }


        public override bool Equals(object obj)
        {
            var student = obj as Student;
            return student != null &&
                   StudenId == student.StudenId &&
                   Name == student.Name &&
                   Surname == student.Surname &&
                   Birthday == student.Birthday &&
                   GuidId.Equals(student.GuidId);
        }

         public override int GetHashCode()
        {
            var hashCode = 1981116738;
            hashCode = hashCode * -1521134295 + StudenId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Surname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Birthday);
            hashCode = hashCode * -1521134295 + EqualityComparer<Guid>.Default.GetHashCode(GuidId);
            return hashCode;
        }
        public override string ToString()
        {
            return String.Format("{0,38},{1,10},{2,-15},{3,-20},{4,-10}",
                this.GuidId, this.StudenId, this.Name, this.Surname, this.Birthday);
        }

      
    }
}
