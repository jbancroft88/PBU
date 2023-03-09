using RoboSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace PBU
{
    public partial class LDCSER : Form
    {
        //// PUBLIC VARIABLES 

        // statistics and paths
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

        // status and device flags
        bool userReady = false;
        string _source = "";
        string _dest = "";

        public LDCSER()
        {
            // Initial parameters
            InitializeComponent();
            btLog.Visible = false;

            // Set Thread Culture 
            CultureInfo culture = null;
            culture = CultureInfo.CreateSpecificCulture("en-US");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
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
            if (userReady == true && (rbBackup.Checked || rbRestore.Checked))
            {
                // start timeout and time elapsed timers & lock functions
                timer_copytimeout.Start();
                rbBackup.Enabled = false;
                rbRestore.Enabled = false;
                btCopy.Enabled = false;
                tbUsername.Enabled = false;
                cbDownloads.Enabled = false;
                cbOneDrive.Enabled = false;
                cbIncPhotos.Enabled = false;
                btListC.Enabled = false;
                btLog.Visible = false;
                tbStagingPath.Enabled = false;
                tbDeviceHostname.Enabled = false;

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
                MessageBox.Show("ERROR: Unable to initialize data transfer. Check the parameters (Username / Server Path / Hostname) are correct and that a process direction has been selected");
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

            string sourceDevice = _source;
            string destDevice = _dest;

            string stdSuffix = "\\c$\\users\\" + tbUsername.Text + currentFolder;
            string stdDestSuffix = "\\c$\\users\\" + tbUsername.Text + currentFolder;

            // operation source and destination parameters
            string sPath = sourceDevice + stdSuffix;
            string dPath = destDevice + stdDestSuffix;

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
                backup.CopyOptions.MultiThreadedCopiesCount = 32;
                backup.CopyOptions.UseUnbufferedIo = false;
                backup.RetryOptions.RetryCount = 1;
                backup.RetryOptions.RetryWaitTime = 1;
                //backup.LoggingOptions.
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
                backup.CopyOptions.MultiThreadedCopiesCount = 32;
                backup.CopyOptions.UseUnbufferedIo = false;
                backup.RetryOptions.RetryCount = 1;
                backup.RetryOptions.RetryWaitTime = 1;
                //backup.LoggingOptions.LogPath = @"C:\logs\pbu\RC_" + copyFlag + "_" + currentItem + "_log.txt"; --seperate logs
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

                    btCopy.Enabled = true;
                    btCopy.Text = "Copy Data";
                    tbUsername.Enabled = true;
                    cbDownloads.Enabled = true;
                    cbOneDrive.Enabled = true;
                    cbIncPhotos.Enabled = true;
                    rbBackup.Enabled = true;
                    rbRestore.Enabled = true;
                    btListC.Enabled = true;
                    tbStagingPath.Enabled = true;
                    tbDeviceHostname.Enabled = true;

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
                MessageBox.Show("TIMEOUT ERROR" + Environment.NewLine + Environment.NewLine +
                    "Network Timeout - Unable to initiate file transfer." + Environment.NewLine + Environment.NewLine +
                    "Check parameters and network status of server and/or user machine");
                Controls.Clear();
                InitializeComponent();
            }
        }

        // ADDITIONAL FUNCTIONS


        private void rbBackup_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBackup.Checked)
            {
                _source = @"\\" + tbDeviceHostname.Text;
                _dest = tbStagingPath.Text + @"\\" + tbUsername.Text;
            }
        }
        private void rbRestore_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRestore.Checked)
            {
                _source = tbStagingPath.Text + @"\\" + tbUsername.Text;
                _dest = @"\\" + tbDeviceHostname.Text;
            }
        }

        // VALIDATE ROOT DIRECTORIES

        private void btListC_Click(object sender, EventArgs e)
        {
            string assettag = tbDeviceHostname.Text;
            // initial exclusion list of directories
            List<string> exdir = new List<string>();
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
            try
            {
                List<string> curdir = new List<string>();
                string[] directories = { };
                string dir = @"\\" + assettag + @"\c$";
                directories = Directory.GetDirectories(dir);

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
            catch
            {
                MessageBox.Show("Please enter valid hostname");
            }

        }

        // ROBOCOPY STOP-PAUSE-LOG BUTTONS

        private void btLog_Click(object sender, EventArgs e)
        // Opens log file in default text viewer
        {
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