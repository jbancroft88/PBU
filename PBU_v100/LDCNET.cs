using RoboSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;

namespace PBU
{
    public partial class LDCNET : Form
    {
        //// PUBLIC VARIABLES 

        // statistics
        long filesCopied = 0;
        long dirCopied = 0;
        long filesFailed = 0;
        long bytesCopied = 0;
        string currentFlag = "";
        int _ticks = 0;
        string _logpath = @"C:\ProgramData\PBU\" + System.DateTime.Now.ToString("yyyy_MM_dd") + @"_rctransfer_log.txt";

        // copy flags
        int copyFlag = 0;
        string currentFolder = "Null";
        string frCurrentFolder = "Null";
        string currentItem = "";
        int currentStatus = 0;
        string frDir = "";

        // status flags
        bool srcReady = true;
        bool dstReady = true;
        bool userReady = false;



        public LDCNET()
        {
            // Initial parameters and form load
            InitializeComponent();
            btLog.Visible = false;

            // Set Culture Info
            CultureInfo culture = null;
            culture = CultureInfo.CreateSpecificCulture("en-US");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
        }

        //// NETWORK VALIDATION CODE

        // SOURCE DEVICE PARAMETERS

        private void cbSourceIsLocal_CheckedChanged(object sender, EventArgs e)
        {
            // override manual entry if the source device is running the application
            if (cbSourceIsLocal.Checked == true)
            {
                tbHostname.Text = "localhost";
                tbHostname.ReadOnly = true;
                btPing.Enabled = false;
                btAuth.Enabled = false;
                tbResult.ForeColor = Color.Green;
                tbResult.Text = "System online: Localhost";
                srcReady = true;
                btListC.Enabled = true;
            }
            else
            {
                tbHostname.Text = "";
                tbHostname.ReadOnly = false;
                btPing.Enabled = true;
                btAuth.Enabled = false;
                tbResult.ForeColor = Color.Aqua;
                tbResult.Text = "Status: Ready to Connect";
                btListC.Enabled = false;
            }
        }
        private void tbHostname_TextChanged(object sender, EventArgs e)
        {
            // validates text in the textbox
            tbResult.Text = "Status: Ready to Connect";
            tbResult.ForeColor = Color.Aqua;
            btAuth.Enabled = false;
            btListC.Enabled = false;

            if (tbHostname.TextLength == 0)
            {
                srcReady = false;
            }
            else
            {
                srcReady = true;
            }
        }
        private void btPing_Click(object sender, EventArgs e)
        {
            // ping function for source device
            if (tbHostname.TextLength < 1)
            {
                MessageBox.Show("Enter a Host Name or IP Address");
            }
            else
            {
                Ping ping = new Ping();
                try
                {
                    PingReply reply = ping.Send(tbHostname.Text, 1000);
                    tbResult.ForeColor = Color.Aqua;
                    tbResult.Text = "System online: Ready to authenticate";
                    btAuth.Enabled = true;
                }
                catch
                {
                    tbResult.ForeColor = Color.Red;
                    tbResult.Text = "Error: Failed to connect to host";
                }
                finally
                {
                    ping.Dispose();
                }
            }
        }
        private void btAuth_Click(object sender, EventArgs e)
        {
            string UNCpath = "\\\\" + tbHostname.Text + "\\c$";
            ExecuteAsAdminSrc(UNCpath);
        }
        public void ExecuteAsAdminSrc(string procArgument)
        // authenticate function for source device
        {
            Process proc = new Process();
            proc.StartInfo.FileName = "explorer.exe";
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.Arguments = procArgument;
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            proc.Start();
            tbResult.ForeColor = Color.Green;
            tbResult.Text = "System online: Authentication Sent";
            btListC.Enabled = true;
        }

        // DESTINATION DEVICE PARAMETERS

        private void cbDestIsLocal_CheckedChanged(object sender, EventArgs e)
        {
            // override manual entry if the destination device is running the application
            if (cbDestIsLocal.Checked == true)
            {
                tbDestHostname.Text = "localhost";
                tbDestHostname.ReadOnly = true;
                btDestPing.Enabled = false;
                btDestAuth.Enabled = false;
                tbDestResult.ForeColor = Color.Green;
                tbDestResult.Text = "System online: Localhost";
                dstReady = true;
            }
            else
            {
                tbDestHostname.Text = "";
                tbDestHostname.ReadOnly = false;
                btDestPing.Enabled = true;
                btDestAuth.Enabled = false;
                tbDestResult.ForeColor = Color.Aqua;
                tbDestResult.Text = "Status: Ready to Connect";
            }
        }

        private void tbDestHostname_TextChanged(object sender, EventArgs e)
        {
            // validates text in the textbox
            tbDestResult.Text = "Status: Ready to Connect";
            tbDestResult.ForeColor = Color.Aqua;
            btDestAuth.Enabled = false;

            if (tbDestHostname.TextLength == 0)
            {
                dstReady = false;
            }
            else
            {
                dstReady = true;
            }
        }

        private void btDestPing_Click(object sender, EventArgs e)
        {
            // ping function for destination device
            if (tbDestHostname.TextLength < 1)
            {
                MessageBox.Show("Enter a Host Name or IP Address");
            }
            else
            {
                Ping ping2 = new Ping();
                try
                {
                    PingReply reply = ping2.Send(tbDestHostname.Text, 1000);
                    tbDestResult.ForeColor = Color.Aqua;
                    tbDestResult.Text = "System online: Ready to authenticate";
                    btDestAuth.Enabled = true;
                }
                catch
                {
                    tbDestResult.ForeColor = Color.Red;
                    tbDestResult.Text = "Error: Failed to connect to host";
                }
                finally
                {
                    ping2.Dispose();
                }
            }
        }
        private void btDestAuth_Click(object sender, EventArgs e)
        {
            string UNCpath = "\\\\" + tbDestHostname.Text + "\\c$\\";
            ExecuteAsAdminDest(UNCpath);
        }
        public void ExecuteAsAdminDest(string procArgument)
        {
            // authenticate function for destination device
            Process proc = new Process();
            proc.StartInfo.FileName = "explorer.exe";
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.Arguments = procArgument;
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            proc.Start();
            tbDestResult.ForeColor = Color.Green;
            tbDestResult.Text = "System online: Authentication Sent";
        }

        // USERNAME VALIDATION FUNCTION

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            // checks that username field is not empty
            if (tbUsername.TextLength == 0)
            {
                userReady = false;
            }
            else
            {
                userReady = true;
            }
        }

        // // COPY INITIALIZE FUNCTION

        public void btCopy_Click(object sender, EventArgs e)
        {
            // checks conditions are met before running (source, destination, username fields are populated)
            if (dstReady == true && srcReady == true && userReady == true)
            {
                // start timeout and time elapsed timers & lock functions
                timer_copytimeout.Start();
                btAuth.Enabled = false;
                btPing.Enabled = false;
                btDestAuth.Enabled = false;
                btDestPing.Enabled = false;
                btCopy.Enabled = false;
                tbHostname.Enabled = false;
                tbDestHostname.Enabled = false;
                tbUsername.Enabled = false;
                cbDestIsLocal.Enabled = false;
                cbSourceIsLocal.Enabled = false;
                cbDownloads.Enabled = false;
                cbOneDrive.Enabled = false;
                cbIncPhotos.Enabled = false;
                btListC.Enabled = false;
                btLog.Visible = false;

                //create Log directory
                System.IO.Directory.CreateDirectory(@"C:\ProgramData\PBU");

                // reset event flags
                Thread updateGUIthread = new Thread(() =>
                {
                    this.BeginInvoke((Action)delegate ()
                    {
                        CurrentOperation.Text = "Attempting to initiate file transfer...";
                        this.pbProgress.Value = 2;
                        CurrentOperation.Text = "";
                        CurrentOperation.ForeColor = Color.White;
                        CurrentFile.Text = "";
                        CurrentSize.Text = "";
                        tbErrors.Text = "";
                        tbSizeCopied.Text = "";
                        filesFailed = 0;
                        filesCopied = 0;
                        dirCopied = 0;
                        bytesCopied = 0;
                    });
                });
                updateGUIthread.Start();

                // check OneDrive copy modifier (skip Desktop and Downloads)
                if (cbOneDrive.Checked == true)
                {
                    copyFlag = 2;
                }

                // initialize file transfer
                Thread.Sleep(1000);
                RoboCopyRun();
            }
            else
            {
                MessageBox.Show("ERROR: Unable to initialize data transfer. Check that the Source, Destination and Username fields are correct and try again.");
            }
        }

        // // // ROBOCOPY ENGINE // // // 

        // FILE EVENT PROCESSOR

        void backup_OnFileProcessed(object sender, FileProcessedEventArgs e)
        {
            // controls seperate thread to update GUI with file processing statistics
            Thread updatethread1 = new Thread(() =>
            {
                this.BeginInvoke((Action)delegate ()
                {
                    _ticks = 0;
                    timer_copytimeout.Stop();
                    var crntSize = e.ProcessedFile.Size / 1000000;
                    btCopy.Text = "File transfer in progress...";
                    CurrentOperation.Text = currentFlag;
                    CurrentOperation.ForeColor = Color.White;
                    CurrentFile.Text = "Copying: " + e.ProcessedFile.Name;
                    CurrentSize.Text = "Size: " + crntSize.ToString() + " MB";
                });
            });
            updatethread1.Start();
        }

        // COMMAND COMPLETION PROCESSOR

        void backup_OnCommandCompleted(object sender, RoboCommandCompletedEventArgs e)
        {
            // tracks total statistics after each cycle 
            var results = e.Results;
            filesCopied += results.FilesStatistic.Copied;
            filesFailed += results.FilesStatistic.Failed;
            dirCopied += results.DirectoriesStatistic.Copied;
            bytesCopied += results.BytesStatistic.Copied;

            // when current operation completes, update the flag and loop back to the main cycle
            copyFlag += 1;
            RoboCopyRun();
        }

        // // ROBOCOPY OPERATION CYCLES

        // 1. PRIMARY LOOP

        public void RoboCopyRun()
        {
            //Check copy modifiers (Downloads / Pictures)
            if (copyFlag == 4 && cbDownloads.Checked)
            {
                copyFlag += 1;
            }
            if (copyFlag == 2 && cbIncPhotos.Checked)
            {
                copyFlag += 1;
            }

            // path assignment based on current copyflag and modifiers
            if (copyFlag == 0)
            {
                currentFolder = "\\Desktop";
                frCurrentFolder = "\\Systemfolders\\Desktop";
                currentItem = "Desktop";
                currentStatus = 15;
            }
            else if (copyFlag == 1)
            {
                currentFolder = "\\Documents";
                frCurrentFolder = currentFolder;
                currentItem = "Documents";
                currentStatus = 30;
            }
            else if (copyFlag == 2)
            {
                currentFolder = "\\Pictures";
                frCurrentFolder = currentFolder;
                currentItem = "Pictures";
                currentStatus = 45;
            }
            else if (copyFlag == 3)
            {
                currentFolder = "\\Favorites";
                currentItem = "IE_Favourites";
                currentStatus = 50;
            }
            else if (copyFlag == 4)
            {
                currentFolder = "\\Downloads";
                currentItem = "Downloads";
                currentStatus = 60;
            }
            else if (copyFlag == 5)
            {
                currentFolder = "\\Music";
                currentItem = "Music";
                currentStatus = 70;
            }
            else if (copyFlag == 6)
            {
                currentFolder = "\\Videos";
                currentItem = "Videos";
                currentStatus = 80;
            }
            else if (copyFlag == 7)
            {
                currentFolder = "\\AppData\\Roaming\\Microsoft\\Signatures";
                currentItem = "Outlook Signatures";
                currentStatus = 85;
            }
            else if (copyFlag == 8)
            {
                currentFolder = "\\AppData\\Local\\Google\\Chrome\\User Data\\Default";
                currentItem = "Chrome_Preferences_and_Bookmarks";
                currentStatus = 90;
            }

            // gets host info
            string sourceDevice = tbHostname.Text;
            string destDevice = tbDestHostname.Text;
            string stdSuffix = "\\c$\\users\\" + tbUsername.Text + currentFolder;
            string stdDestSuffix = "\\c$\\users\\" + tbUsername.Text + currentFolder;

            // operation source and destination parameters
            string sPath = "\\\\" + sourceDevice + stdSuffix;
            string dPath = "\\\\" + destDevice + stdDestSuffix;

            // create path if it does not exist in source (otherwise error is encountered)
            try
            {
                System.IO.Directory.CreateDirectory(sPath);
            }
            catch
            {
                CurrentOperation.Text = "ERROR: No response from source machine. Retrying...";
            }

            // main copy engine
            if (copyFlag < 8)
            {
                RoboCommand backup = new RoboCommand();
                backup.OnFileProcessed += backup_OnFileProcessed;
                backup.OnCommandCompleted += backup_OnCommandCompleted;
                backup.CopyOptions.Source = sPath;
                backup.CopyOptions.Destination = dPath;
                backup.CopyOptions.CopySubdirectoriesIncludingEmpty = true;
                backup.CopyOptions.UseUnbufferedIo = false;
                backup.CopyOptions.MultiThreadedCopiesCount = 32;
                backup.RetryOptions.RetryCount = 1;
                backup.RetryOptions.RetryWaitTime = 2;
                backup.LoggingOptions.AppendLogPath = _logpath;
                backup.LoggingOptions.OutputToRoboSharpAndLog = true;
                backup.LoggingOptions.VerboseOutput = false;
                backup.Start();
            }
            // final copy (different options for Chrome data. on completion, breaks out of loop to end cycle)
            if (copyFlag == 8)
            {
                RoboCommand backup = new RoboCommand();
                backup.OnFileProcessed += backup_OnFileProcessed;
                backup.OnCommandCompleted += EndCycle;
                backup.CopyOptions.Source = sPath;
                backup.CopyOptions.Destination = dPath;
                backup.CopyOptions.CopySubdirectoriesIncludingEmpty = false;
                backup.CopyOptions.UseUnbufferedIo = false;
                backup.CopyOptions.MultiThreadedCopiesCount = 32;
                backup.RetryOptions.RetryCount = 1;
                backup.RetryOptions.RetryWaitTime = 2;
                backup.LoggingOptions.AppendLogPath = _logpath;
                backup.LoggingOptions.OutputToRoboSharpAndLog = true;
                backup.LoggingOptions.VerboseOutput = false;
                backup.Start();
            }

            // Second thread for updating GUI with current operation status
            Thread updateGUIthread = new Thread(() =>
            {
                this.BeginInvoke((Action)delegate ()
                {
                    currentFlag = "Copying " + currentItem;
                    pbProgress.Value = currentStatus;
                });
            });
            updateGUIthread.Start();
        }

        // 2. END CYCLE

        void EndCycle(object sender, RoboCommandCompletedEventArgs e)
        {
            Thread updatethread2 = new Thread(() =>
            {
                this.BeginInvoke((Action)delegate ()
                {
                    // unlock functions and reset flags
                    copyFlag = 0;
                    btLog.Visible = true;

                    btAuth.Enabled = true;
                    btPing.Enabled = true;
                    btDestAuth.Enabled = true;
                    btDestPing.Enabled = true;
                    btCopy.Enabled = true;
                    btCopy.Text = "Copy Data";
                    tbHostname.Enabled = true;
                    tbDestHostname.Enabled = true;
                    tbUsername.Enabled = true;
                    cbDestIsLocal.Enabled = true;
                    cbSourceIsLocal.Enabled = true;
                    cbDownloads.Enabled = true;
                    cbOneDrive.Enabled = true;
                    cbIncPhotos.Enabled = true;
                    if (cbSourceIsLocal.Checked)
                    {
                        btListC.Enabled = true;
                    }
                    else
                    {
                        btListC.Enabled = false;
                    }


                    // show collated statistics
                    var results = e.Results;
                    filesCopied += results.FilesStatistic.Copied;
                    filesFailed += results.FilesStatistic.Failed;
                    dirCopied += results.DirectoriesStatistic.Copied;
                    bytesCopied += results.BytesStatistic.Copied;
                    long totalBytes = bytesCopied / 1000000;

                    Thread.Sleep(200);

                    // display result
                    if (filesCopied > 0)
                    {
                        this.pbProgress.Value = 100;
                        CurrentOperation.ForeColor = Color.Green;
                        CurrentOperation.Text = "Data Transfer Complete";
                        CurrentFile.Text = "Files Copied: " + filesCopied;
                        CurrentSize.Text = "Directories Copied: " + dirCopied;
                        tbErrors.Text = "Failed During Transfer: " + filesFailed;
                        tbSizeCopied.Text = "Total Data: " + totalBytes + " MB";
                    }
                    else
                    {
                        CurrentOperation.Text = "Error";
                        CurrentOperation.ForeColor = Color.Red;
                        CurrentFile.Text = "Files copied: 0";
                        CurrentSize.Text = "Check parameters and try again";
                        this.pbProgress.Value = 0;
                    }
                });
            });
            updatethread2.Start();
        }

        // TIMEOUT ERROR HANDLING
        private void timer_copytimeout_Tick(object sender, EventArgs e)
        {
            _ticks++;
            lbTimer.Text = _ticks.ToString();
            if (_ticks > 15)
            {
                _ticks = 0;
                timer_copytimeout.Stop();
                MessageBox.Show("NETWORK TIMEOUT ERROR" + Environment.NewLine + Environment.NewLine +
                    "Unable to initiate file transfer. " + Environment.NewLine + Environment.NewLine +
                    "Check the connection and authentication status of both SOURCE and DESTINATION endpoints. " +
                    "If using folder redirection, please check server status and user directory.");
                Controls.Clear();
                InitializeComponent();
            }
        }

        // VALIDATE ROOT DIRECTORIES FUNCTION
        // lists non-standard directories on C:\ drive where potential user-created content exists
        private void btListC_Click(object sender, EventArgs e)
        {
            string assettag = tbHostname.Text;
            if (tbHostname.TextLength > 0 || cbSourceIsLocal.Checked)
            {
                // initial exclusion list of directories
                List<string> exdir = new List<string>();
                //local
                exdir.Add(@"c:\$Recycle.Bin");
                exdir.Add(@"c:\Appslogs");
                exdir.Add(@"c:\boot");
                exdir.Add(@"c:\Dell");
                exdir.Add(@"c:\Documents and Settings");
                exdir.Add(@"c:\DRVRS");
                exdir.Add(@"c:\Intel");
                exdir.Add(@"c:\IntelOptaneData");
                exdir.Add(@"c:\OneDriveTemp");
                exdir.Add(@"c:\PerfLogs");
                exdir.Add(@"c:\Premium_Logon");
                exdir.Add(@"c:\Program Files");
                exdir.Add(@"c:\Program Files (x86)");
                exdir.Add(@"c:\ProgramData");
                exdir.Add(@"c:\Recovery");
                exdir.Add(@"c:\sf3");
                exdir.Add(@"c:\System Volume Information");
                exdir.Add(@"c:\Windows");
                exdir.Add(@"c:\usr");
                exdir.Add(@"c:\Users");
                exdir.Add(@"c:\MSOCache");
                exdir.Add(@"c:\UADiagnostics");
                // remote
                exdir.Add(@"\\" + assettag + @"\c$\$Recycle.Bin");
                exdir.Add(@"\\" + assettag + @"\c$\Appslogs");
                exdir.Add(@"\\" + assettag + @"\c$\boot");
                exdir.Add(@"\\" + assettag + @"\c$\Dell");
                exdir.Add(@"\\" + assettag + @"\c$\Documents and Settings");
                exdir.Add(@"\\" + assettag + @"\c$\DRVRS");
                exdir.Add(@"\\" + assettag + @"\c$\Intel");
                exdir.Add(@"\\" + assettag + @"\c$\IntelOptaneData");
                exdir.Add(@"\\" + assettag + @"\c$\OneDriveTemp");
                exdir.Add(@"\\" + assettag + @"\c$\PerfLogs");
                exdir.Add(@"\\" + assettag + @"\c$\Premium_Logon");
                exdir.Add(@"\\" + assettag + @"\c$\Program Files");
                exdir.Add(@"\\" + assettag + @"\c$\Program Files (x86)");
                exdir.Add(@"\\" + assettag + @"\c$\ProgramData");
                exdir.Add(@"\\" + assettag + @"\c$\Recovery");
                exdir.Add(@"\\" + assettag + @"\c$\sf3");
                exdir.Add(@"\\" + assettag + @"\c$\System Volume Information");
                exdir.Add(@"\\" + assettag + @"\c$\Windows");
                exdir.Add(@"\\" + assettag + @"\c$\usr");
                exdir.Add(@"\\" + assettag + @"\c$\Users");
                exdir.Add(@"\\" + assettag + @"\c$\MSOCache");
                exdir.Add(@"\\" + assettag + @"\c$\UADiagnostics");

                // gets list of current directories on current C:\
                List<string> curdir = new List<string>();
                string[] directories = { };
                if (cbSourceIsLocal.Checked)
                {
                    directories = Directory.GetDirectories(@"c:\");
                }
                else
                {
                    string dir = @"\\" + assettag + @"\c$";
                    directories = Directory.GetDirectories(dir);
                }

                foreach (string i in directories)
                {
                    curdir.Add(i);
                }

                // compares exclusion list with current directories and outputs exceptions
                var outputdir = curdir.Except(exdir).ToList();
                string msg = string.Join(Environment.NewLine, outputdir);
                MessageBox.Show(@"The following non-system folders were indentified within the C:\ drive root directory:" + Environment.NewLine + Environment.NewLine +
                        msg + Environment.NewLine + Environment.NewLine +
                        "Check the above folders for any user created data and, if neccesary, copy their contents to the User 'Documents' folder before initiating a file transfer to mitigate potential data loss");

            }
        }

        private void btLog_Click(object sender, EventArgs e)
        {
            // Opens log file in default text viewer
            try
            {
                Process proc = new Process();
                proc.StartInfo.FileName = _logpath;
                proc.StartInfo.UseShellExecute = true;
                proc.Start();
            }
            catch
            {
                MessageBox.Show("No log file created.");
            }
        }
    }
}




