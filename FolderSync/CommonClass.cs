using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;

namespace FolderSync
{
    class CommonClass
    {
       // String MainFileName = "product.xml";
        String MainFileNamenew = "product.xml";
        String MailFile = "mailmessage.xml";
        /* Product XML Format*/
         
        ////public string ReadXML()
        ////{
        ////    XmlDataDocument xmldoc = new XmlDataDocument();
        ////    XmlNodeList xmlnode;
        ////    int i = 0;
        ////    string str = null;
        ////    string contstr = "";
        ////    FileStream fs = new FileStream(MainFileName, FileMode.Open, FileAccess.Read);
        ////    xmldoc.Load(fs);
        ////    xmlnode = xmldoc.GetElementsByTagName("Job");
        ////    for (i = 0; i <= xmlnode.Count - 1; i++)
        ////    {
        ////        xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
        ////        str = xmlnode[i].ChildNodes.Item(0).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(1).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(2).InnerText.Trim();
        ////        contstr = contstr + str;
        ////    }
        ////    return contstr;
        ////}
        public List<JobModel> ReadXMLNew()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(MainFileNamenew);
            XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/Table/Job");
            
            List<JobModel> iJobName = new List<JobModel> { };

            foreach (XmlNode node in nodeList)
            {
                try
                {

                
                JobModel jobName= new JobModel();
                  jobName.JobId = Convert.ToInt32(node.SelectSingleNode("Job_id").InnerXml) ;
                  jobName.JobName = node.SelectSingleNode("Job_name").InnerXml;
                  jobName.Source_Address = node.SelectSingleNode("Source_Address").InnerXml;
                  jobName.Source_Folder = node.SelectSingleNode("Source_Folder").InnerXml;
                  jobName.Source_Username = node.SelectSingleNode("Source_UserName").InnerXml;
                  jobName.Source_Password = node.SelectSingleNode("Source_Password").InnerXml;
                  jobName.Destination_Address = node.SelectSingleNode("Destination_Address").InnerXml;

                  jobName.Deleteold =Convert.ToBoolean( node.SelectSingleNode("Deleteold").InnerXml);
                  jobName.DeleteDays = Convert.ToInt32(node.SelectSingleNode("DeleteDays").InnerXml);

                  jobName.Destination_UserName = "";//node.SelectSingleNode("Destination_UserName").InnerXml;
                  jobName.Destination_Password = "";//node.SelectSingleNode("Destination_Password").InnerXml;
                iJobName.Add(jobName);
                //MessageBox.Show(proID + " " + proName + " " + price);
                }
                catch (Exception ex)
                {

                   Console.WriteLine(ex.ToString());
                }
            }
            return iJobName;
        }
        public MailClass ReadXMLMail()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(MailFile);
            XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/Table/Mail");

            MailClass iMailClass = null;

            foreach (XmlNode node in nodeList)
            {
                iMailClass = new MailClass();
                iMailClass.MailFrom =node.SelectSingleNode("Mail_From").InnerXml;
                iMailClass.MailTo = node.SelectSingleNode("Mail_To").InnerXml;
                iMailClass.MailSubject = node.SelectSingleNode("Mail_Subject").InnerXml;
                iMailClass.MailAcceptBody = node.SelectSingleNode("Mail_Accept_Body").InnerXml;
                iMailClass.MailRejectBody = node.SelectSingleNode("Mail_Reject_Body").InnerXml;

                iMailClass.MailPassword = node.SelectSingleNode("Mail_Password").InnerXml;
                iMailClass.MailServer = node.SelectSingleNode("Mail_Server").InnerXml;
                int time_hr = Convert.ToInt16(node.SelectSingleNode("Timer_HR").InnerXml);
                int time_mm = Convert.ToInt16(node.SelectSingleNode("Timer_MM").InnerXml);
                int time_ss = Convert.ToInt16(node.SelectSingleNode("Timer_SS").InnerXml);
                if (time_hr>24 && time_hr<0)
                {
                    time_hr = 0;
                }
                if (time_mm > 60 && time_mm < 0)
                {
                    time_mm = 0;
                }
                if (time_ss > 60 && time_ss < 0)
                {
                    time_ss = 0;
                }
                iMailClass.Timer = new TimeSpan(time_hr, time_mm, time_ss);
                
                //MessageBox.Show(proID + " " + proName + " " + price);
            }
            return iMailClass;
        }
        public void SendCustomMail(MailClass iMailClass,string MailSubject, string MailBody)
        {
           // MailClass iMailClass = new MailClass();
            //string MailFrom = "System@info.com.np";
            try
            {
               // SmtpClient smtp = new SmtpClient(iMailClass.MailServer,25);
                SmtpClient smtp = new SmtpClient(iMailClass.MailServer, 587);
                smtp.EnableSsl = true;
                String Username = iMailClass.MailFrom;
                String Password = iMailClass.MailPassword;
               System.Net.NetworkCredential cred = new System.Net.NetworkCredential(Username, Password);
                smtp.Credentials = cred;
              //  smtp.UseDefaultCredentials = true;
               // smtp.UseDefaultCredentials = true;
                 MailMessage newemail = new MailMessage();

                 newemail.From = new MailAddress(iMailClass.MailFrom);
                 if (iMailClass.MailTo.Contains("@"))
                 {
                     newemail.To.Add(iMailClass.MailTo);
                 }
                 newemail.Body = MailBody;
                 newemail.Subject = MailSubject;
                 newemail.IsBodyHtml = false;
                //newmail.Attachments.Add(oAttch)
                //if Attachment is need
                 ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(ValidateServerCertificate);
                 smtp.Send(newemail);


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
        }

        public static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            if (sslPolicyErrors == SslPolicyErrors.None)
                return true;
            else
            {
               // if (System.Windows.Forms.MessageBox.Show("The server certificate is not valid.\nAccept?", "Certificate Validation", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    return true;
                //else
                  //  return false;
            }
        }
        ////public FileClass StringtoFileClass(string dInput)
        ////{
        ////    string[] iStrip = dInput.Split(' ');
        ////    FileClass iFileName= new FileClass();
        ////    //Date 0 
        ////    //Time 1
        ////    //FileName
        ////    string CombineDate = iStrip[0].ToString() + " " + iStrip[1].ToString();
        ////    string FileName = dInput.Substring(CombineDate.Length, dInput.Length - CombineDate.Length - 1);
        ////    iFileName.FileDate = Convert.ToDateTime(iStrip[0].ToString());
        ////    iFileName.FileName = FileName.TrimStart();

        ////    return iFileName;
        ////}
    }
}
