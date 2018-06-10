using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace FolderSync
{
    public class JobModel
    {
        
        public int JobId { get; set; }
        public string JobName { get; set; }
        public string Source_Folder { get; set; }
        public string Destination_Address { get; set; }
        public string  Destination_UserName { get; set; }
        public string Destination_Password { get; set; }
        public string Source_Address { get; set; }
        public string Source_Username { get; set; }
        public string Source_Password { get; set; }
        public Boolean Status { get; set; }
        public Boolean Deleteold { get; set; }
        [DefaultValue(10)]
        public int DeleteDays { get; set; }

        public JobModel()//int iJobId, string iJobName)
        {
          //  JobId = iJobId;
           // JobName = iJobName;
            Status = false;
            Deleteold = false;
            DeleteDays = 10;
        }
    }
}
