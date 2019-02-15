using System;
using System.Collections.Generic;

namespace VuelingSchool.Common.Library.Models
{

    public class Student
    {
        public string studenId { set; get; }
        public string name { set; get; }
        public string surname { set; get; }
        public string birthday { set; get; }
        public Guid guidId { set; get; }

        public Student() {

        }

        public Student(string studenId, string name, string surname, string birthday, Guid guidId)
        {
            this.studenId = studenId;
            this.name = name;
            this.surname = surname;
            this.birthday = birthday;
            this.guidId = guidId;
        }

        public override bool Equals(object obj)
        {
            var student = obj as Student;
            return student != null &&
                   studenId == student.studenId &&
                   name == student.name &&
                   surname == student.surname &&
                   birthday == student.birthday &&
                   guidId.Equals(student.guidId);
        }

        public override int GetHashCode()
        {
            var hashCode = 1426189730;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(studenId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(surname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(birthday);
            hashCode = hashCode * -1521134295 + EqualityComparer<Guid>.Default.GetHashCode(guidId);
            return hashCode;
        }

        public override string ToString()
        {
            return String.Format("GuidId     : {0}  " + "," +
                                 "StundentId : {1}  " + "," +
                                 "Name       : {2}  " + "," +
                                 "Surname    : {3}  " + "," +
                                 "Birthday   : {4}  \r\n",
                this.guidId, this.studenId, this.name, this.surname, this.birthday);
        }

    }
}
