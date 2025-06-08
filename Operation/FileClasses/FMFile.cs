using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Login.Page
{
    //FM: Financial Management
    internal class FMFile:AppFile
    {
        private string fullpath;
        public FMFile()
        {
            fullpath = "";
        }
        public FMFile(string path)
        {
            fullpath = path;
        }
    }
}
