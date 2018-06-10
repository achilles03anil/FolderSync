using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FolderSync
{
    public class MailClass
    {
        public string MailFrom { get; set; }
        public string MailSubject { get; set; }
        public string MailTo { get; set; }
        public string MailAcceptBody { get; set; }
        public string MailAttachment { get; set; }
        public string MailRejectBody { get; set; }
        public string MailServer { get; set; }
        public string MailPassword { get; set; }

        public TimeSpan Timer { get; set; }


    }
}
