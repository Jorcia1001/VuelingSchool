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

        public void SaveTxt(String content)
        {
            File.WriteAllText(Path, content);
        }
    }
}
