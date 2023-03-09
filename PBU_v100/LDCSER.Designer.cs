using System;

namespace PBU
{
    partial class LDCSER
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LDCSER));
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.lbCopyOptions = new System.Windows.Forms.Label();
            this.btCopy = new System.Windows.Forms.Button();
            this.CurrentOperation = new System.Windows.Forms.TextBox();
            this.CurrentFile = new System.Windows.Forms.TextBox();
            this.CurrentSize = new System.Windows.Forms.TextBox();
            this.cbOneDrive = new System.Windows.Forms.CheckBox();
            this.timer_copytimeout = new System.Windows.Forms.Timer(this.components);
            this.lbTimer = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.tbErrors = new System.Windows.Forms.TextBox();
            this.tbSizeCopied = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.cbDownloads = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbIncPhotos = new System.Windows.Forms.CheckBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lbServer = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbProcDir = new System.Windows.Forms.Label();
            this.rbBackup = new System.Windows.Forms.RadioButton();
            this.rbRestore = new System.Windows.Forms.RadioButton();
            this.btListC = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btLog = new System.Windows.Forms.Button();
            this.tbStagingPath = new System.Windows.Forms.TextBox();
            this.lbAsset = new System.Windows.Forms.Label();
            this.tbDeviceHostname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pbProgress
            // 
            this.pbProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(60)))));
            this.pbProgress.ForeColor = System.Drawing.Color.Salmon;
            this.pbProgress.Location = new System.Drawing.Point(350, 350);
            this.pbProgress.Margin = new System.Windows.Forms.Padding(2);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(296, 16);
            this.pbProgress.TabIndex = 4;
            // 
            // lbCopyOptions
            // 
            this.lbCopyOptions.AutoSize = true;
            this.lbCopyOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.lbCopyOptions.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCopyOptions.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCopyOptions.Location = new System.Drawing.Point(347, 80);
            this.lbCopyOptions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCopyOptions.Name = "lbCopyOptions";
            this.lbCopyOptions.Size = new System.Drawing.Size(91, 14);
            this.lbCopyOptions.TabIndex = 6;
            this.lbCopyOptions.Text = "Copy Options";
            // 
            // btCopy
            // 
            this.btCopy.BackColor = System.Drawing.Color.RoyalBlue;
            this.btCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCopy.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCopy.ForeColor = System.Drawing.Color.FloralWhite;
            this.btCopy.Location = new System.Drawing.Point(350, 283);
            this.btCopy.Margin = new System.Windows.Forms.Padding(2);
            this.btCopy.Name = "btCopy";
            this.btCopy.Size = new System.Drawing.Size(296, 55);
            this.btCopy.TabIndex = 7;
            this.btCopy.Text = "Copy Files";
            this.btCopy.UseVisualStyleBackColor = false;
            this.btCopy.Click += new System.EventHandler(this.btCopy_Click);
            // 
            // CurrentOperation
            // 
            this.CurrentOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.CurrentOperation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrentOperation.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentOperation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CurrentOperation.Location = new System.Drawing.Point(41, 411);
            this.CurrentOperation.Margin = new System.Windows.Forms.Padding(2);
            this.CurrentOperation.Name = "CurrentOperation";
            this.CurrentOperation.ReadOnly = true;
            this.CurrentOperation.Size = new System.Drawing.Size(595, 13);
            this.CurrentOperation.TabIndex = 11;
            // 
            // CurrentFile
            // 
            this.CurrentFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.CurrentFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrentFile.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CurrentFile.Location = new System.Drawing.Point(41, 434);
            this.CurrentFile.Margin = new System.Windows.Forms.Padding(2);
            this.CurrentFile.Name = "CurrentFile";
            this.CurrentFile.ReadOnly = true;
            this.CurrentFile.Size = new System.Drawing.Size(595, 13);
            this.CurrentFile.TabIndex = 12;
            // 
            // CurrentSize
            // 
            this.CurrentSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.CurrentSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrentSize.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentSize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CurrentSize.Location = new System.Drawing.Point(41, 458);
            this.CurrentSize.Margin = new System.Windows.Forms.Padding(2);
            this.CurrentSize.Name = "CurrentSize";
            this.CurrentSize.ReadOnly = true;
            this.CurrentSize.Size = new System.Drawing.Size(595, 13);
            this.CurrentSize.TabIndex = 13;
            // 
            // cbOneDrive
            // 
            this.cbOneDrive.AutoSize = true;
            this.cbOneDrive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(61)))));
            this.cbOneDrive.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOneDrive.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cbOneDrive.Location = new System.Drawing.Point(350, 104);
            this.cbOneDrive.Margin = new System.Windows.Forms.Padding(2);
            this.cbOneDrive.Name = "cbOneDrive";
            this.cbOneDrive.Size = new System.Drawing.Size(296, 17);
            this.cbOneDrive.TabIndex = 14;
            this.cbOneDrive.Text = "Skip Desktop and Documents (OneDrive enabled)";
            this.cbOneDrive.UseVisualStyleBackColor = false;
            // 
            // timer_copytimeout
            // 
            this.timer_copytimeout.Interval = 1000;
            this.timer_copytimeout.Tick += new System.EventHandler(this.timer_copytimeout_Tick);
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Location = new System.Drawing.Point(16, 537);
            this.lbTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(0, 13);
            this.lbTimer.TabIndex = 22;
            this.lbTimer.Visible = false;
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(83)))));
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUsername.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.ForeColor = System.Drawing.SystemColors.Window;
            this.tbUsername.Location = new System.Drawing.Point(123, 77);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(192, 20);
            this.tbUsername.TabIndex = 23;
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.lbUsername.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbUsername.Location = new System.Drawing.Point(28, 80);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(56, 14);
            this.lbUsername.TabIndex = 24;
            this.lbUsername.Text = "User ID";
            // 
            // tbErrors
            // 
            this.tbErrors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.tbErrors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbErrors.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbErrors.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbErrors.Location = new System.Drawing.Point(41, 482);
            this.tbErrors.Margin = new System.Windows.Forms.Padding(2);
            this.tbErrors.Name = "tbErrors";
            this.tbErrors.ReadOnly = true;
            this.tbErrors.Size = new System.Drawing.Size(595, 13);
            this.tbErrors.TabIndex = 13;
            // 
            // tbSizeCopied
            // 
            this.tbSizeCopied.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.tbSizeCopied.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSizeCopied.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSizeCopied.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbSizeCopied.Location = new System.Drawing.Point(41, 506);
            this.tbSizeCopied.Margin = new System.Windows.Forms.Padding(2);
            this.tbSizeCopied.Name = "tbSizeCopied";
            this.tbSizeCopied.ReadOnly = true;
            this.tbSizeCopied.Size = new System.Drawing.Size(595, 13);
            this.tbSizeCopied.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(337, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(323, 186);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Location = new System.Drawing.Point(21, 251);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(300, 127);
            this.pictureBox5.TabIndex = 31;
            this.pictureBox5.TabStop = false;
            // 
            // cbDownloads
            // 
            this.cbDownloads.AutoSize = true;
            this.cbDownloads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(61)))));
            this.cbDownloads.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDownloads.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cbDownloads.Location = new System.Drawing.Point(350, 140);
            this.cbDownloads.Margin = new System.Windows.Forms.Padding(2);
            this.cbDownloads.Name = "cbDownloads";
            this.cbDownloads.Size = new System.Drawing.Size(110, 17);
            this.cbDownloads.TabIndex = 33;
            this.cbDownloads.Text = "Skip Downloads";
            this.cbDownloads.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(21, 393);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(639, 142);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // cbIncPhotos
            // 
            this.cbIncPhotos.AutoSize = true;
            this.cbIncPhotos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(61)))));
            this.cbIncPhotos.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIncPhotos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cbIncPhotos.Location = new System.Drawing.Point(350, 122);
            this.cbIncPhotos.Margin = new System.Windows.Forms.Padding(2);
            this.cbIncPhotos.Name = "cbIncPhotos";
            this.cbIncPhotos.Size = new System.Drawing.Size(104, 17);
            this.cbIncPhotos.TabIndex = 35;
            this.cbIncPhotos.Text = "Skip Pictures";
            this.cbIncPhotos.UseVisualStyleBackColor = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(61)))));
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Location = new System.Drawing.Point(343, 100);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(310, 150);
            this.pictureBox6.TabIndex = 40;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox8.Location = new System.Drawing.Point(337, 271);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(323, 107);
            this.pictureBox8.TabIndex = 43;
            this.pictureBox8.TabStop = false;
            // 
            // lbServer
            // 
            this.lbServer.AutoSize = true;
            this.lbServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.lbServer.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbServer.Location = new System.Drawing.Point(27, 155);
            this.lbServer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(182, 14);
            this.lbServer.TabIndex = 48;
            this.lbServer.Text = "Server Storage Path (UNC)";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(61)))));
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(27, 283);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(288, 89);
            this.pictureBox3.TabIndex = 51;
            this.pictureBox3.TabStop = false;
            // 
            // lbProcDir
            // 
            this.lbProcDir.AutoSize = true;
            this.lbProcDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.lbProcDir.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcDir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbProcDir.Location = new System.Drawing.Point(28, 259);
            this.lbProcDir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProcDir.Name = "lbProcDir";
            this.lbProcDir.Size = new System.Drawing.Size(126, 14);
            this.lbProcDir.TabIndex = 52;
            this.lbProcDir.Text = "Process Direction";
            // 
            // rbBackup
            // 
            this.rbBackup.AutoSize = true;
            this.rbBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(61)))));
            this.rbBackup.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBackup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbBackup.Location = new System.Drawing.Point(41, 298);
            this.rbBackup.Name = "rbBackup";
            this.rbBackup.Size = new System.Drawing.Size(172, 18);
            this.rbBackup.TabIndex = 53;
            this.rbBackup.TabStop = true;
            this.rbBackup.Text = "Backup Data to Server";
            this.rbBackup.UseVisualStyleBackColor = false;
            this.rbBackup.CheckedChanged += new System.EventHandler(this.rbBackup_CheckedChanged);
            // 
            // rbRestore
            // 
            this.rbRestore.AutoSize = true;
            this.rbRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(61)))));
            this.rbRestore.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRestore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbRestore.Location = new System.Drawing.Point(41, 331);
            this.rbRestore.Name = "rbRestore";
            this.rbRestore.Size = new System.Drawing.Size(221, 18);
            this.rbRestore.TabIndex = 54;
            this.rbRestore.TabStop = true;
            this.rbRestore.Text = "Restore Data to User Machine";
            this.rbRestore.UseVisualStyleBackColor = false;
            this.rbRestore.CheckedChanged += new System.EventHandler(this.rbRestore_CheckedChanged);
            // 
            // btListC
            // 
            this.btListC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.btListC.FlatAppearance.BorderSize = 0;
            this.btListC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btListC.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btListC.Location = new System.Drawing.Point(30, 201);
            this.btListC.Margin = new System.Windows.Forms.Padding(2);
            this.btListC.Name = "btListC";
            this.btListC.Size = new System.Drawing.Size(283, 22);
            this.btListC.TabIndex = 55;
            this.btListC.Text = "Validate (C:\\) Root Directories";
            this.btListC.UseVisualStyleBackColor = false;
            this.btListC.Click += new System.EventHandler(this.btListC_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(21, 71);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(300, 162);
            this.pictureBox4.TabIndex = 56;
            this.pictureBox4.TabStop = false;
            // 
            // btLog
            // 
            this.btLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(61)))));
            this.btLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLog.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLog.ForeColor = System.Drawing.Color.FloralWhite;
            this.btLog.Location = new System.Drawing.Point(496, 499);
            this.btLog.Margin = new System.Windows.Forms.Padding(2);
            this.btLog.Name = "btLog";
            this.btLog.Size = new System.Drawing.Size(157, 25);
            this.btLog.TabIndex = 59;
            this.btLog.Text = "Show Log";
            this.btLog.UseVisualStyleBackColor = false;
            this.btLog.Visible = false;
            this.btLog.Click += new System.EventHandler(this.btLog_Click);
            // 
            // tbStagingPath
            // 
            this.tbStagingPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(83)))));
            this.tbStagingPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbStagingPath.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStagingPath.ForeColor = System.Drawing.SystemColors.Window;
            this.tbStagingPath.Location = new System.Drawing.Point(27, 173);
            this.tbStagingPath.Margin = new System.Windows.Forms.Padding(2);
            this.tbStagingPath.Name = "tbStagingPath";
            this.tbStagingPath.Size = new System.Drawing.Size(288, 20);
            this.tbStagingPath.TabIndex = 60;
            // 
            // lbAsset
            // 
            this.lbAsset.AutoSize = true;
            this.lbAsset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.lbAsset.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAsset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAsset.Location = new System.Drawing.Point(28, 111);
            this.lbAsset.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAsset.Name = "lbAsset";
            this.lbAsset.Size = new System.Drawing.Size(147, 14);
            this.lbAsset.TabIndex = 61;
            this.lbAsset.Text = "Device Hostname / IP";
            // 
            // tbDeviceHostname
            // 
            this.tbDeviceHostname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(83)))));
            this.tbDeviceHostname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDeviceHostname.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDeviceHostname.ForeColor = System.Drawing.SystemColors.Window;
            this.tbDeviceHostname.Location = new System.Drawing.Point(27, 129);
            this.tbDeviceHostname.Margin = new System.Windows.Forms.Padding(2);
            this.tbDeviceHostname.Name = "tbDeviceHostname";
            this.tbDeviceHostname.Size = new System.Drawing.Size(288, 20);
            this.tbDeviceHostname.TabIndex = 62;
            this.tbDeviceHostname.Text = "localhost";
            // 
            // LDCSER
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 559);
            this.Controls.Add(this.tbDeviceHostname);
            this.Controls.Add(this.lbAsset);
            this.Controls.Add(this.tbStagingPath);
            this.Controls.Add(this.btLog);
            this.Controls.Add(this.btListC);
            this.Controls.Add(this.rbRestore);
            this.Controls.Add(this.rbBackup);
            this.Controls.Add(this.lbProcDir);
            this.Controls.Add(this.lbServer);
            this.Controls.Add(this.cbIncPhotos);
            this.Controls.Add(this.cbDownloads);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.cbOneDrive);
            this.Controls.Add(this.tbSizeCopied);
            this.Controls.Add(this.tbErrors);
            this.Controls.Add(this.CurrentSize);
            this.Controls.Add(this.CurrentFile);
            this.Controls.Add(this.CurrentOperation);
            this.Controls.Add(this.btCopy);
            this.Controls.Add(this.lbCopyOptions);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LDCSER";
            this.Text = "PBU";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.Label lbCopyOptions;
        private System.Windows.Forms.Button btCopy;
        private System.Windows.Forms.TextBox CurrentOperation;
        private System.Windows.Forms.TextBox CurrentFile;
        private System.Windows.Forms.TextBox CurrentSize;
        private System.Windows.Forms.CheckBox cbOneDrive;
        private System.Windows.Forms.Timer timer_copytimeout;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox tbErrors;
        private System.Windows.Forms.TextBox tbSizeCopied;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.CheckBox cbDownloads;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbIncPhotos;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lbServer;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbProcDir;
        private System.Windows.Forms.RadioButton rbBackup;
        private System.Windows.Forms.RadioButton rbRestore;
        private System.Windows.Forms.Button btListC;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btLog;
        private System.Windows.Forms.TextBox tbStagingPath;
        private System.Windows.Forms.Label lbAsset;
        private System.Windows.Forms.TextBox tbDeviceHostname;
    }
}

