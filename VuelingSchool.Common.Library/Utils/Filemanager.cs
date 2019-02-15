using System;
using System.IO;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuelingSchool.Common.Library.Utils
{
    public class Filemanager
    {
        private readonly string Path = "Student.txt";
        public string Content { set; get; }

        public Filemanager(string content)
        {
            Content = content;
        }

        public void AddContent(string content)
        {
            File.AppendAllText(Path, content);
        }

        public void OnCreate()
        {
            FileStream fs = File.Open(Path, FileMode.Create);
            fs.Close();
        }

        public void OnExist()
        {
            FileStream fs;
            try
            {
               fs = File.Open(Path, FileMode.Open);
               fs.Close();
            }
            catch(FileNotFoundException fnfe)
            {
                //The File don't exist, the we will create it.
                System.Diagnostics.Debug.WriteLine(fnfe.Message);
                OnCreate();
            }
           
           

        }


    }
}
