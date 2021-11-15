using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENCRYPTOR
{
    class FileHandeler
    {
        public string Reader(string filepath, string filename)
        {
            return (System.IO.File.ReadAllText(filepath+filename));

        }

        public void Writer(string filepath, string filename, string filecontnent)
        {
            using (StreamWriter sw = File.CreateText(filepath + filename))
            {
                sw.WriteLine(filecontnent);
            }
        }
    }
}
