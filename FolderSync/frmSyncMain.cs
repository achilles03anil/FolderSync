using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FolderSync
{
    public partial class frmSyncMain : Form
    {
        System.Threading.Thread dThread = null;
        public List<JobModel> iJobList;
        public MailClass iMailClass;
        int dAddGap = 1;
        int buffersize = 2048;
        int bytesize = 8;
        CommonClass iClass = new CommonClass();
        static TimeSpan backuptime = new TimeSpan(3, 0, 0);//Backup at 3 AM
        DateTime output = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, backuptime.Hours, backuptime.Minutes, backuptime.Seconds);
        DateTime dStartDate = DateTime.Today;
        DateTime dEndDate = DateTime.Today;
        Boolean BackupStatus = false;
        static string dMailHeader = "Dear Sir,"+Environment.NewLine + "The filenames listed below are been backedup."+Environment.NewLine;
        string dFolderName = DateTime.Today.Year.ToString() + "_" + DateTime.Today.Month.ToString() + "_" + DateTime.Today.Day.ToString()+ "_" + DateTime.Now.ToShortTimeString().Replace(":","_");
       public delegate void ProgressBarStatus(int value);
        public frmSyncMain()
        {
            InitializeComponent();
        }

        private void frmSyncMain_Load(object sender, EventArgs e)
        {
            dStartDate = output.AddDays(-dAddGap);
            dEndDate = output;
             if (ReadXmlFiles() == false)
             {
                 MessageBox.Show("Error Reading XML File");
             }
        }
        public void CleanTxtFolder()
        {
            try
            {
                string dConsole = txtConsole.Text;
                txtConsole.Text = "";
                string fileName = Path.Combine(Directory.GetCurrentDirectory(), dStartDate.ToString("yyyyMMdd_HHmmss") + "_FileName.txt");
                // Ensure the file is created and closed before writing
                //using (FileStream fs = File.Create(fileName))
                //{
                //    fs.Close(); // Close the file immediately
                //}
               // File.Create(fileName).Dispose();  // Ensure it's closed immediately
                File.WriteAllText(fileName, dConsole);
                //File.Create(dStartDate.ToBinary().ToString() + "FileName.txt");
                //File.WriteAllText(dStartDate.ToBinary().ToString() + "FileName.txt", dConsole);
                

            }
            catch (Exception ex)
            {
           }
           
        }
        public void RefreshTime()
        {
             output = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, backuptime.Hours, backuptime.Minutes, backuptime.Seconds);
       
            dStartDate = output.AddDays(-dAddGap);
            dEndDate = output;
            dFolderName = DateTime.Today.Year.ToString() + "_" + DateTime.Today.Month.ToString() + "_" + DateTime.Today.Day.ToString()+ "_" + DateTime.Now.ToShortTimeString().Replace(":", "_");
        }

        private void readXMLFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ReadXmlFiles()==false)
            {
                MessageBox.Show("Error Reading XML File");
            }
        }
        public Boolean ReadXmlFiles()
        {
            Boolean dReadStatus = false;
            try
            {
                  iJobList = new List<JobModel> { };
            iMailClass = new MailClass();
            
            //txtConsole.Text = iClass.ReadXML();
            ConsoleText("Read XML");
            iJobList = iClass.ReadXMLNew();
            iMailClass = iClass.ReadXMLMail();
            lblTimerAt.Text = iMailClass.Timer.ToString();
            if (iMailClass.Timer!=null)
            {
                backuptime = iMailClass.Timer;
            }
            LoadListView(lstMain, iJobList);
            LoadMailMessage(iMailClass);
            dReadStatus = true;
            }
            catch (Exception ex)
            {

                dReadStatus = false;
            }

            return dReadStatus;
        }
        public void LoadListView(ListView dList, List<JobModel> dJob)
        {
            dList.Items.Clear();
            dList.View = View.Details;
           // dList.HeaderStyle = ColumnHeaderStyle.None;
           // ColumnHeader h = new ColumnHeader();
           // h.Width = dList.ClientSize.Width - SystemInformation.VerticalScrollBarWidth;
           // dList.Columns.Add(h);
            dList.Columns.Add("SN", 20, HorizontalAlignment.Left);
            dList.Columns.Add("Name", Convert.ToInt32(dList.Width-20), HorizontalAlignment.Left);
           // dList.Columns.Add(h);
            foreach (var item in dJob)
            {
               // dList.Items.Add(new ListViewItem(item.JobName));
                dList.Items.Add(new ListViewItem(new string[] { item.JobId.ToString(), item.JobName }));
            }
        }
        public void LoadMailMessage(MailClass iMailClass)
        {
            if (iMailClass!=null)
            {
                txtMailMessage.Clear();
                txtMailMessage.AppendText("Mail_From");
                txtMailMessage.AppendText(" : ");
                txtMailMessage.AppendText(iMailClass.MailFrom.ToString()); txtMailMessage.AppendText(Environment.NewLine);

                txtMailMessage.AppendText("Mail_To");
                txtMailMessage.AppendText(" : ");
                txtMailMessage.AppendText(iMailClass.MailTo.ToString()); txtMailMessage.AppendText(Environment.NewLine);

                txtMailMessage.AppendText("Mail_Server");
                txtMailMessage.AppendText(" : ");
                txtMailMessage.AppendText(iMailClass.MailServer.ToString()); txtMailMessage.AppendText(Environment.NewLine);

        
            }
        }
        public void LoadListFileClass(ListView dList, List<FileClass> dFile)
        {
            if (dList.InvokeRequired == true)
            {
                dList.BeginInvoke(new Action<ListView, List<FileClass>>(LoadListFileClass),dList, dFile);
            }
            else
            {
                if (dFile != null)
                {
                    dList.Items.Clear();
                    dList.Columns.Clear();
                    dList.View = View.Details;
                    dList.Columns.Add("SN", 50, HorizontalAlignment.Left);
                    dList.Columns.Add("Name", Convert.ToInt32(dList.Width - 100), HorizontalAlignment.Left);
                    dList.Columns.Add("Size", Convert.ToInt32(100), HorizontalAlignment.Right);
                    foreach (var item in dFile)
                    {
                        dList.Items.Add(new ListViewItem(new string[] { item.FileDate.ToString(), item.FileName, item.FileSize.ToString() }));
                    }
                }
            }
        }
       
        public void ReadJobClass(){
            ConsoleText("Start Job");
            RefreshTime();
            ConsoleText("Refresh Time");
            if (iJobList!=null)
            {
                for (int i = 0; i < iJobList.Count; i++)
                {
                    StartJob(iJobList[i]);
                }
            }
        }

        ////public void StartJob(JobModel iJobModelOne)
        ////{
        ////   // dStartDate = new DateTime(2018, 2, 1);
        ////    if (iJobModelOne!=null)
        ////        {
        ////        //Create Connection    
        ////        FTPClass iFtp = new FTPClass(@"ftp://" + iJobModelOne.Source_Address.ToString()+ ":65224", iJobModelOne.Source_Username, iJobModelOne.Source_Password);
        ////          //Listed Directory  
        ////        /* Get Contents of a Directory with Detailed File/Directory Info */
        ////        List<FileClass> iFileList = iFtp.directoryListDetailClass("/");
        ////        ////string[] detailDirectoryListing = iFtp.directoryListDetailed("/");
        ////        ////for (int i = 0; i < detailDirectoryListing.Count(); i++) { 
        ////        ////    string[] iFileName=detailDirectoryListing[i].Split(' ');
        ////        ////    if (iFileName[0]!=null && iFileName[0]!="")
        ////        ////    {
        ////        ////        DateTime dFileDate= Convert.ToDateTime(iFileName[0].ToString());
        ////        ////       if (dStartDate < dFileDate && dFileDate < dEndDate)
        ////        ////        {
        ////        ////                   txtConsole.AppendText(detailDirectoryListing[i]);
        ////        ////                   txtConsole.AppendText(Environment.NewLine);
        ////        ////        }
        ////        ////    }
                  
                    
        ////        ////}
        ////        }
            
        ////}

        public string DeleteFolder(JobModel iJobModelOne)
        {
            string Deletestr = "";
            List<string> iDeleteFileList = new List<string> { };
            if (iJobModelOne.Destination_Address!=null)
            {
                //Get the folder list
                string[] iDirectorylist = Directory.GetDirectories(iJobModelOne.Destination_Address);
                for (int i = 0; i < iDirectorylist.Count(); i++)
                {//Criteria Matches
                  
                    if (iJobModelOne.Deleteold==true)
                    {
                        DateTime dExpirydate = dEndDate.AddDays(-iJobModelOne.DeleteDays);
                        if (Directory.GetCreationTime(iJobModelOne.Destination_Address+"/"+ iDirectorylist[i])<dExpirydate)
                        {
                            iDeleteFileList.Add(iDeleteFileList[i]);
                            Deletestr = Deletestr + i + " : " + iDeleteFileList[i] + Environment.NewLine;
                        }
                    }
                   
                }
                //Final Deletion of the directory
                foreach (var item in iDeleteFileList)
                {
                    Directory.Delete(iJobModelOne.Destination_Address + "/" + item,true);
                }
            }
            return Deletestr;

        }
        public string StartSync(JobModel iJobModelOne, List<FileClass> iFileList)
        {
            List<FileClass> iComplete = new List<FileClass> { };
            string iCompleteStr = "";
            Boolean overAllDownloadStatus = true;
            try
            {

                string dSourceFolder = "";
                if (iJobModelOne.Source_Folder != "/") { dSourceFolder = "/" + iJobModelOne.Source_Folder; }
            if (iJobModelOne != null && iFileList!=null)
            {
                //Create Connection    
                FTPClass iFtp = new FTPClass(@"ftp://" + iJobModelOne.Source_Address.ToString() + ":"+iJobModelOne.Source_Port.ToString() + "" + dSourceFolder, iJobModelOne.Source_Username, iJobModelOne.Source_Password, iJobModelOne.PassiveMode);
                //Listed Directory  
                /* Get Contents of a Directory with Detailed File/Directory Info */
                iFtp.ProgressBarCallback = new ProgressBarStatus(this.DisplayProgressBarValue);
                int FileCount = iFileList.Count();
                int i = 1;
                String dDestinationFolderName = iJobModelOne.Destination_Address + dFolderName;
                //Check  if the Directory exist
                if (iFileList.Count>0)//Directory.Exists(dDestinationFolderName) == false)
                {
                    ConsoleText(iJobModelOne.JobName + " Folder Created Start : " + dDestinationFolderName);
                    Directory.CreateDirectory(dDestinationFolderName);

                    foreach (var item in iFileList)
                    {
                        //pgBarLabel.Step = 2048;
                        
                        DisplayText(lblFileName, item.FileName.ToString() + ":" + i + "/" + FileCount);
                        ConsoleText(iJobModelOne.JobName + " File Name  : " + item.FileName.ToString());
                        string downloadstatus= iFtp.downloadwithProgress(item.FileName.ToString(), dDestinationFolderName + "/" + item.FileName.ToString());
                        if (downloadstatus != "Complete Download : " + item.FileName.ToString())
                        {
                            overAllDownloadStatus = false;
                            break;
                        }
                        iComplete.Add(item);
                        iCompleteStr = iCompleteStr + i + " : " + item.FileName.ToString() + Environment.NewLine;
                        ConsoleText(iJobModelOne.JobName + " Download Status : " +downloadstatus);
                       
                        i = i + 1;
                        //break;
                    }
                }
                else
                { 
                
                    ConsoleText(iJobModelOne.JobName + " Sync Empty Folder " );
                    iCompleteStr = "Backup Empty";
                }
                if (overAllDownloadStatus==false)
                {
                     ConsoleText(iJobModelOne.JobName + " Sync Empty Folder " );
                    iCompleteStr = "Backup Empty";
                }
                
            }
           
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.InnerException.ToString());

            }
            LoadListFileClass(lstDestination, iComplete);
            BackupStatus = false;
            return iCompleteStr;
        }
        public void StartJob(JobModel iJobModelOne)
        {
            BackupStatus = true;
            try
            {

           
            
            string dMailBody = "";

            string dSourceFolder = "/";
            if (iJobModelOne.Source_Folder != "/") {dSourceFolder= "/"+iJobModelOne.Source_Folder; }
            if (iJobModelOne != null)
            {
                //Create Connection    
                FTPClass iFtp = new FTPClass(@"ftp://" + iJobModelOne.Source_Address.ToString() + ":" + iJobModelOne.Source_Port.ToString() + "" + dSourceFolder, iJobModelOne.Source_Username, iJobModelOne.Source_Password, iJobModelOne.PassiveMode);
                   
                //Listed Directory  
                /* Get Contents of a Directory with Detailed File/Directory Info */
                System.Threading.Thread.Sleep(2000);
                List<FileClass> iFileList = iFtp.directoryListDetailClass("/");
                ConsoleText(iJobModelOne.JobName + " Files Count " + iFileList.Count);
                List<FileClass> iFilterFile = new List<FileClass> { };

                foreach (var item in iFileList)
                {
                    DateTime dFileDate = Convert.ToDateTime(item.FileDate);
                    if (dStartDate < dFileDate && dFileDate <= dEndDate)
                    {
                        iFilterFile.Add(item);
                    }
                }
                ConsoleText(iJobModelOne.JobName + " Filtered Count " + iFilterFile.Count);
                LoadListFileClass(lstSource, iFilterFile);
               
                
                //Send Email After Backup
                if (iFilterFile.Count>0)
                {
                    ConsoleText(iJobModelOne.JobName + " Sync Start  " + iFilterFile.Count);
                    dMailBody = StartSync(iJobModelOne, iFilterFile);
                    ConsoleText(iJobModelOne.JobName + " Sync Ended  " + iFilterFile.Count);
                    iClass.SendCustomMail(iMailClass, "Backup of " + iJobModelOne.JobName.ToString(), dMailHeader + dMailBody);
                    ConsoleText(iJobModelOne.JobName + " Email Sent  " );
                }
                
                if (iJobModelOne.Deleteold==true)
                {
                 //   DeleteFolder(iJobModelOne);
                }
            }
            }
            catch (Exception ex)
            {
                BackupStatus = false;
                ConsoleText( " Start Job Error :" + ex.Message.ToString());
                // throw;
            }
            BackupStatus = false;
        }
      
        public void ListingJobDetails (JobModel iJobModelOne)
        {
            BackupStatus = true;
            try
            {



                string dMailBody = "";

                string dSourceFolder = "/";
                if (iJobModelOne.Source_Folder != "/") { dSourceFolder = "/" + iJobModelOne.Source_Folder; }
                if (iJobModelOne != null)
                {
                    //Create Connection    
                    FTPClass iFtp = new FTPClass(@"ftp://" + iJobModelOne.Source_Address.ToString() + ":"+ iJobModelOne.Source_Port + "" + dSourceFolder, iJobModelOne.Source_Username, iJobModelOne.Source_Password, iJobModelOne.PassiveMode);

                   // Thread.Sleep(2000);
                    //Listed Directory  
                    /* Get Contents of a Directory with Detailed File/Directory Info */
                    System.Threading.Thread.Sleep(2000);
                    List<FileClass> iFileList = iFtp.directoryListDetailClass("");
                    ConsoleText(iJobModelOne.JobName + " Files Count " + iFileList.Count);
                    List<FileClass> iFilterFile = new List<FileClass> { };

                    foreach (var item in iFileList)
                    {
                        DateTime dFileDate = Convert.ToDateTime(item.FileDate);
                        if (dStartDate < dFileDate && dFileDate <= dEndDate)
                        {
                            iFilterFile.Add(item);
                        }
                    }
                    ConsoleText(iJobModelOne.JobName + " Filtered Count " + iFilterFile.Count);
                    LoadListFileClass(lstSource, iFilterFile);


                    //Send Email After Backup
                    ////if (iFilterFile.Count > 0)
                    ////{
                    ////    ConsoleText(iJobModelOne.JobName + " Sync Start  " + iFilterFile.Count);
                    ////    dMailBody = StartSync(iJobModelOne, iFilterFile);
                    ////    ConsoleText(iJobModelOne.JobName + " Sync Ended  " + iFilterFile.Count);
                    ////    iClass.SendCustomMail(iMailClass, "Backup of " + iJobModelOne.JobName.ToString(), dMailHeader + dMailBody);
                    ////    ConsoleText(iJobModelOne.JobName + " Email Sent  ");
                    ////}

                    if (iJobModelOne.Deleteold == true)
                    {
                        //   DeleteFolder(iJobModelOne);
                    }
                }
            }
            catch (Exception ex)
            {
                BackupStatus = false;
                ConsoleText(" Start Job Error :" + ex.Message.ToString());
                // throw;
            }
            BackupStatus = false;
        }
        
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
          // WorkingAgent();
        }
        public void WorkingAgent()
        {
            //dThreadStart = true;
           // tmrBackup.Stop();
            if (BackupStatus == false)
            {
                bgWorker.WorkerReportsProgress = true;
                bgWorker.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Already in Work");
            }
            
        }
        public void DisplayText(Label lbl, String dString)
        {
            if (lbl.InvokeRequired == true)
            {
                lbl.BeginInvoke(new Action<Label, String>(DisplayText), lbl, dString);
            }
            else
            {
                lbl.Text = dString;
            }
        }

        public void TextVisible(Label lbl, Boolean dStatus)
        {
            if (lbl.InvokeRequired == true)
            {
                lbl.BeginInvoke(new Action<Label, Boolean>(TextVisible), lbl, dStatus);
            }
            else
            {
                lbl.Visible = dStatus;
            }
        }
        public void DisplayProgressBarValue(int dValue)
        {
            if (pgBarLabel.InvokeRequired == true)
            {
                pgBarLabel.BeginInvoke(new Action<int>(DisplayProgressBarValue), dValue);
            }
            else
            {
                //int i = 0;
                dValue = dValue / (buffersize *100 );
                               
                //if (dValue > 100) {
                //    dValue = 1;
                //}
                


               // pgBarLabel.Value = dValue;
                ////if (pgBarLabel.Value > 0) {
                ////    DisplayText(lblpercentage, dValue+"%");
                ////}

                DisplayText(lblpercentage, dValue + "%");
            }
        }
        public void DisplayProgressBarSetting(int dMaxValue)
        {
            if (pgBarLabel.InvokeRequired == true)
            {
                pgBarLabel.BeginInvoke(new Action<int>(DisplayProgressBarSetting), dMaxValue);
            }
            else
            {
                pgBarLabel.Maximum = dMaxValue;
                
            }
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ReadJobClass();
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           // dThread.Abort();
            BackupStatus = false;
            tmrBackup.Enabled = true;
            TimerCount(true);
        }

        private void chkConsole_CheckedChanged(object sender, EventArgs e)
        {
            SCConsole.Panel2Collapsed = !chkConsole.Checked;
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // iClass.SendCustomMail(iMailClass, "Test Message", "Mail Body");
            iClass.TestSendCustomMail();
        }

        private void tmrBackup_Tick(object sender, EventArgs e)
        {
            TimeSpan Currenttime = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
             if (Currenttime == backuptime) // Checking Current time with Backup time
             {
                 tmrBackup.Enabled = false;
                 StartBackup();
                 CleanTxtFolder();
             }
             else
             {
                 TimeSpan lefttime = Currenttime - backuptime;
                 lblTimerStarts.Text = Currenttime.ToString() + " Hrs";
             }
        }
        public void StartBackup()
        {
            TimerCount(false);
            WorkingAgent();
        }
        public void TimerCount(Boolean  dStatus)
        {
            tmrBackup.Enabled = dStatus;
            if (dStatus==true)
            {
                lblTimerCount.BackColor = Color.LightGreen;
                //lblTimerCount.Text = dcounterTrue + " Secs";
                lblTimerCount.Text = "Enabled";
                
            }
            else
            {
                lblTimerCount.BackColor = Color.Gray;
                lblTimerCount.Text = "Disabled";
            }
            
        }

        private void readFromListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartBackup();
        }
        public void ConsoleText(string newLine)
        {
            if (txtConsole.InvokeRequired == true)
            {
                txtConsole.BeginInvoke(new Action<string>(ConsoleText), newLine);
            }
            else
            {
                txtConsole.AppendText(DateTime.Now.ToShortDateString() +" "+DateTime.Now.ToShortTimeString()+" " + newLine + Environment.NewLine);

            }
        }

        private void clearConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CleanTxtFolder();
        }

        private void listFTPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstMain.Items.Count>0)
            {
                int iSelectedItem = lstMain.SelectedIndices[0];
                if (iSelectedItem>-1)
                {
                    ListingJobDetails(iJobList[iSelectedItem]);
                }
                 

            }
        }
    }
}
