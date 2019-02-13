using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuelingSchool.Common.Library.Models
{
    public class Student
    {
        public Student(int studenId, string name, string surname, string birthday)
        {
            StudenId = studenId;
            Name = name;
            Surname = surname;
            Birthday = birthday;
        }

        int    StudenId { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        string Birthday { get; set; }

        public override string ToString()
        {
            return String.Format("StundentId :{0} " + ","+
                                 "Name       : {1}" + "," +
                                 "Surname    : {2}" + "," +
                                 "Birthday   : {3}" + ",", 
                this.StudenId, this.Name,this.Surname,this.Birthday);
        }

    }
}
