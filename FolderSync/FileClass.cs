using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FolderSync
{
    public class FileClass
    {
          
        public DateTime FileDate { get; set; }
        public double   FileSize { get; set; }
        public string FileName { get; set; }
        public Boolean FileOrDir { get; set; }

        public FileClass()
        {
            FileOrDir = true;
        }
    }
}
