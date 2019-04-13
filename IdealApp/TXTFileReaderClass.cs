using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdealApp
{
    public class TXTFileReaderClass
    {
        //this always return string from file!

        public string pass { get; set; } //pass to file

        TXTFileReaderClass(string filePass)
        {
            pass = filePass;
        }
    }
}
