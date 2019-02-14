using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuelingSchool.Common.Library.Models
{
    public class Student
    {
        private string studenId;
        private string name;
        private string surname;
        private string birthday;
        private Guid guidId;

        public Student() { }
            



        public string StudenId { get => studenId; set => studenId = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Birthday{ get => birthday; set => birthday = value; }
        public Guid GuidId { get => guidId; set => guidId = value; }

        public override string ToString()
        {
            return String.Format("GuidId     : {0}  " + ","+
                                 "StundentId : {1}  " + ","+
                                 "Name       : {2}  " + "," +
                                 "Surname    : {3}  " + "," +
                                 "Birthday   : {4}  \r\n", 
                this.guidId,this.studenId, this.name,this.surname,this.birthday);
        }

    }
}
