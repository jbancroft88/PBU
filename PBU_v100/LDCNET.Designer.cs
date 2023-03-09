using System;

namespace PBU
{
    partial class LDCNET
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LDCNET));
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.lbCopyOptions = new System.Windows.Forms.Label();
            this.btCopy = new System.Windows.Forms.Button();
            this.CurrentOperation = new System.Windows.Forms.TextBox();
            this.CurrentFile = new System.Windows.Forms.TextBox();
            this.CurrentSize = new System.Windows.Forms.TextBox();
            this.cbOneDrive = new System.Windows.Forms.CheckBox();
            this.btDestAuth = new System.Windows.Forms.Button();
            this.tbDestResult = new System.Windows.Forms.TextBox();
            this.btDestPing = new System.Windows.Forms.Button();
            this.lblDestHostName = new System.Windows.Forms.Label();
            this.tbDestHostname = new System.Windows.Forms.TextBox();
            this.cbDestIsLocal = new System.Windows.Forms.CheckBox();
            this.tbHostname = new System.Windows.Forms.TextBox();
            this.lbSrcHostName = new System.Windows.Forms.Label();
            this.btPing = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btAuth = new System.Windows.Forms.Button();
            this.cbSourceIsLocal = new System.Windows.Forms.CheckBox();
            this.timer_copytimeout = new System.Windows.Forms.Timer(this.components);
            this.lbTimer = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.tbErrors = new System.Windows.Forms.TextBox();
            this.tbSizeCopied = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.cbDownloads = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbIncPhotos = new System.Windows.Forms.CheckBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btListC = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.btLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
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
            this.btCopy.BackColor = System.Drawing.Color.Teal;
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
            // btDestAuth
            // 
            this.btDestAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.btDestAuth.Enabled = false;
            this.btDestAuth.FlatAppearance.BorderSize = 0;
            this.btDestAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDestAuth.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDestAuth.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDestAuth.Location = new System.Drawing.Point(171, 328);
            this.btDestAuth.Margin = new System.Windows.Forms.Padding(2);
            this.btDestAuth.Name = "btDestAuth";
            this.btDestAuth.Size = new System.Drawing.Size(144, 22);
            this.btDestAuth.TabIndex = 19;
            this.btDestAuth.Text = "Authenticate";
            this.btDestAuth.UseVisualStyleBackColor = false;
            this.btDestAuth.Click += new System.EventHandler(this.btDestAuth_Click);
            // 
            // tbDestResult
            // 
            this.tbDestResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.tbDestResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDestResult.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDestResult.ForeColor = System.Drawing.Color.Aqua;
            this.tbDestResult.Location = new System.Drawing.Point(29, 356);
            this.tbDestResult.Margin = new System.Windows.Forms.Padding(2);
            this.tbDestResult.Name = "tbDestResult";
            this.tbDestResult.ReadOnly = true;
            this.tbDestResult.Size = new System.Drawing.Size(284, 13);
            this.tbDestResult.TabIndex = 18;
            this.tbDestResult.Text = "Status: Ready to Connect";
            // 
            // btDestPing
            // 
            this.btDestPing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.btDestPing.FlatAppearance.BorderSize = 0;
            this.btDestPing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDestPing.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDestPing.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDestPing.Location = new System.Drawing.Point(29, 328);
            this.btDestPing.Margin = new System.Windows.Forms.Padding(2);
            this.btDestPing.Name = "btDestPing";
            this.btDestPing.Size = new System.Drawing.Size(137, 22);
            this.btDestPing.TabIndex = 17;
            this.btDestPing.Text = "Ping";
            this.btDestPing.UseVisualStyleBackColor = false;
            this.btDestPing.Click += new System.EventHandler(this.btDestPing_Click);
            // 
            // lblDestHostName
            // 
            this.lblDestHostName.AutoSize = true;
            this.lblDestHostName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.lblDestHostName.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestHostName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDestHostName.Location = new System.Drawing.Point(27, 282);
            this.lblDestHostName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDestHostName.Name = "lblDestHostName";
            this.lblDestHostName.Size = new System.Drawing.Size(182, 14);
            this.lblDestHostName.TabIndex = 16;
            this.lblDestHostName.Text = "Destination Hostname / IP";
            // 
            // tbDestHostname
            // 
            this.tbDestHostname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(83)))));
            this.tbDestHostname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDestHostname.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDestHostname.ForeColor = System.Drawing.SystemColors.Window;
            this.tbDestHostname.Location = new System.Drawing.Point(113, 302);
            this.tbDestHostname.Margin = new System.Windows.Forms.Padding(2);
            this.tbDestHostname.Name = "tbDestHostname";
            this.tbDestHostname.Size = new System.Drawing.Size(202, 20);
            this.tbDestHostname.TabIndex = 15;
            this.tbDestHostname.TextChanged += new System.EventHandler(this.tbDestHostname_TextChanged);
            // 
            // cbDestIsLocal
            // 
            this.cbDestIsLocal.AutoSize = true;
            this.cbDestIsLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.cbDestIsLocal.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDestIsLocal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbDestIsLocal.Location = new System.Drawing.Point(30, 305);
            this.cbDestIsLocal.Margin = new System.Windows.Forms.Padding(2);
            this.cbDestIsLocal.Name = "cbDestIsLocal";
            this.cbDestIsLocal.Size = new System.Drawing.Size(80, 17);
            this.cbDestIsLocal.TabIndex = 21;
            this.cbDestIsLocal.Text = "localhost";
            this.cbDestIsLocal.UseVisualStyleBackColor = false;
            this.cbDestIsLocal.CheckedChanged += new System.EventHandler(this.cbDestIsLocal_CheckedChanged);
            // 
            // tbHostname
            // 
            this.tbHostname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(83)))));
            this.tbHostname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHostname.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHostname.ForeColor = System.Drawing.SystemColors.Window;
            this.tbHostname.Location = new System.Drawing.Point(113, 148);
            this.tbHostname.Margin = new System.Windows.Forms.Padding(2);
            this.tbHostname.Name = "tbHostname";
            this.tbHostname.Size = new System.Drawing.Size(202, 20);
            this.tbHostname.TabIndex = 0;
            this.tbHostname.TextChanged += new System.EventHandler(this.tbHostname_TextChanged);
            // 
            // lbSrcHostName
            // 
            this.lbSrcHostName.AutoSize = true;
            this.lbSrcHostName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.lbSrcHostName.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSrcHostName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSrcHostName.Location = new System.Drawing.Point(26, 128);
            this.lbSrcHostName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSrcHostName.Name = "lbSrcHostName";
            this.lbSrcHostName.Size = new System.Drawing.Size(147, 14);
            this.lbSrcHostName.TabIndex = 1;
            this.lbSrcHostName.Text = "Source Hostname / IP";
            // 
            // btPing
            // 
            this.btPing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.btPing.FlatAppearance.BorderSize = 0;
            this.btPing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPing.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPing.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btPing.Location = new System.Drawing.Point(28, 174);
            this.btPing.Margin = new System.Windows.Forms.Padding(2);
            this.btPing.Name = "btPing";
            this.btPing.Size = new System.Drawing.Size(140, 22);
            this.btPing.TabIndex = 2;
            this.btPing.Text = "Ping";
            this.btPing.UseVisualStyleBackColor = false;
            this.btPing.Click += new System.EventHandler(this.btPing_Click);
            // 
            // tbResult
            // 
            this.tbResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.tbResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbResult.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResult.ForeColor = System.Drawing.Color.Aqua;
            this.tbResult.Location = new System.Drawing.Point(31, 202);
            this.tbResult.Margin = new System.Windows.Forms.Padding(2);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(284, 13);
            this.tbResult.TabIndex = 3;
            this.tbResult.Text = "Status: Ready to Connect";
            // 
            // btAuth
            // 
            this.btAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.btAuth.Enabled = false;
            this.btAuth.FlatAppearance.BorderSize = 0;
            this.btAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAuth.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAuth.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAuth.Location = new System.Drawing.Point(172, 174);
            this.btAuth.Margin = new System.Windows.Forms.Padding(2);
            this.btAuth.Name = "btAuth";
            this.btAuth.Size = new System.Drawing.Size(143, 22);
            this.btAuth.TabIndex = 5;
            this.btAuth.Text = "Authenticate";
            this.btAuth.UseVisualStyleBackColor = false;
            this.btAuth.Click += new System.EventHandler(this.btAuth_Click);
            // 
            // cbSourceIsLocal
            // 
            this.cbSourceIsLocal.AutoSize = true;
            this.cbSourceIsLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.cbSourceIsLocal.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSourceIsLocal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbSourceIsLocal.Location = new System.Drawing.Point(29, 151);
            this.cbSourceIsLocal.Margin = new System.Windows.Forms.Padding(2);
            this.cbSourceIsLocal.Name = "cbSourceIsLocal";
            this.cbSourceIsLocal.Size = new System.Drawing.Size(80, 17);
            this.cbSourceIsLocal.TabIndex = 20;
            this.cbSourceIsLocal.Text = "localhost";
            this.cbSourceIsLocal.UseVisualStyleBackColor = false;
            this.cbSourceIsLocal.CheckedChanged += new System.EventHandler(this.cbSourceIsLocal_CheckedChanged);
            // 
            // timer_copytimeout
            // 
            this.timer_copytimeout.Interval = 1000;
            this.timer_copytimeout.Tick += new System.EventHandler(this.timer_copytimeout_Tick);
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Location = new System.Drawing.Point(38, 333);
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
            this.tbUsername.Location = new System.Drawing.Point(113, 77);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(202, 20);
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
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(21, 271);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(300, 107);
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(21, 119);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(300, 138);
            this.pictureBox4.TabIndex = 30;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Location = new System.Drawing.Point(21, 71);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(300, 32);
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
            this.pictureBox6.Size = new System.Drawing.Size(310, 151);
            this.pictureBox6.TabIndex = 40;
            this.pictureBox6.TabStop = false;
            // 
            // btListC
            // 
            this.btListC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.btListC.Enabled = false;
            this.btListC.FlatAppearance.BorderSize = 0;
            this.btListC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btListC.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btListC.Location = new System.Drawing.Point(31, 222);
            this.btListC.Margin = new System.Windows.Forms.Padding(2);
            this.btListC.Name = "btListC";
            this.btListC.Size = new System.Drawing.Size(283, 22);
            this.btListC.TabIndex = 42;
            this.btListC.Text = "Validate (C:\\) Root Directories";
            this.btListC.UseVisualStyleBackColor = false;
            this.btListC.Click += new System.EventHandler(this.btListC_Click);
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
            this.btLog.TabIndex = 60;
            this.btLog.Text = "Show Log";
            this.btLog.UseVisualStyleBackColor = false;
            this.btLog.Visible = false;
            this.btLog.Click += new System.EventHandler(this.btLog_Click);
            // 
            // LDCNET
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 559);
            this.Controls.Add(this.btLog);
            this.Controls.Add(this.btListC);
            this.Controls.Add(this.cbIncPhotos);
            this.Controls.Add(this.cbDownloads);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.cbDestIsLocal);
            this.Controls.Add(this.cbSourceIsLocal);
            this.Controls.Add(this.btDestAuth);
            this.Controls.Add(this.tbDestResult);
            this.Controls.Add(this.btDestPing);
            this.Controls.Add(this.lblDestHostName);
            this.Controls.Add(this.tbDestHostname);
            this.Controls.Add(this.cbOneDrive);
            this.Controls.Add(this.tbSizeCopied);
            this.Controls.Add(this.tbErrors);
            this.Controls.Add(this.CurrentSize);
            this.Controls.Add(this.CurrentFile);
            this.Controls.Add(this.CurrentOperation);
            this.Controls.Add(this.btCopy);
            this.Controls.Add(this.lbCopyOptions);
            this.Controls.Add(this.btAuth);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btPing);
            this.Controls.Add(this.lbSrcHostName);
            this.Controls.Add(this.tbHostname);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LDCNET";
            this.Text = "PBU";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
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
        private System.Windows.Forms.Button btDestAuth;
        private System.Windows.Forms.TextBox tbDestResult;
        private System.Windows.Forms.Button btDestPing;
        private System.Windows.Forms.Label lblDestHostName;
        private System.Windows.Forms.TextBox tbDestHostname;
        private System.Windows.Forms.CheckBox cbDestIsLocal;
        private System.Windows.Forms.TextBox tbHostname;
        private System.Windows.Forms.Label lbSrcHostName;
        private System.Windows.Forms.Button btPing;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btAuth;
        private System.Windows.Forms.CheckBox cbSourceIsLocal;
        private System.Windows.Forms.Timer timer_copytimeout;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox tbErrors;
        private System.Windows.Forms.TextBox tbSizeCopied;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.CheckBox cbDownloads;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbIncPhotos;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btListC;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button btLog;
    }
}

