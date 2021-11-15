using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENCRYPTOR
{
    class FileHandeler
    {
        public string Reader(string filepath)
        {
            return (System.IO.File.ReadAllText(filepath));

        }
    }
}
