namespace Auto_Print
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.cmdCancelPrinting = new System.Windows.Forms.Button();
            this.lblPhotosLeft = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblPicCount = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.cmdToPrint = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmdSettings = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlPicFinder = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdFind = new System.Windows.Forms.Button();
            this.cboPicture = new System.Windows.Forms.ComboBox();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlPrint = new System.Windows.Forms.Panel();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.cboPrinter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tmTime = new System.Windows.Forms.Timer(this.components);
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtPicSize = new System.Windows.Forms.TextBox();
            this.cmdPicSize = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtLocalSave = new System.Windows.Forms.TextBox();
            this.cmdBrowseLocalSave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtWaitInterval = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmdSaveInterval = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdSaveFTP = new System.Windows.Forms.Button();
            this.cmdCancelFTP = new System.Windows.Forms.Button();
            this.txtFTPFamily = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFTPAdult = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFTPChild = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFTPRF = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFTPPort = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFTPPasssword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFTPUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFTPHost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmdSaveNewPhoto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddDescription = new System.Windows.Forms.TextBox();
            this.txtAddPhoto = new System.Windows.Forms.TextBox();
            this.lstdescription = new System.Windows.Forms.ListBox();
            this.lstNames = new System.Windows.Forms.ListBox();
            this.cmdDeletePhoto = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlPrinter = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.cboPaperSize = new System.Windows.Forms.ComboBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlPicFinder.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlPrinter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.Black;
            this.pnlLeft.Controls.Add(this.cmdCancelPrinting);
            this.pnlLeft.Controls.Add(this.lblPhotosLeft);
            this.pnlLeft.Controls.Add(this.label20);
            this.pnlLeft.Controls.Add(this.lblPicCount);
            this.pnlLeft.Controls.Add(this.label18);
            this.pnlLeft.Controls.Add(this.lblInfo);
            this.pnlLeft.Controls.Add(this.lblTime);
            this.pnlLeft.Controls.Add(this.cmdToPrint);
            this.pnlLeft.Controls.Add(this.lblDate);
            this.pnlLeft.Controls.Add(this.cmdSettings);
            this.pnlLeft.Controls.Add(this.pictureBox1);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(165, 759);
            this.pnlLeft.TabIndex = 0;
            // 
            // cmdCancelPrinting
            // 
            this.cmdCancelPrinting.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdCancelPrinting.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdCancelPrinting.FlatAppearance.BorderSize = 5;
            this.cmdCancelPrinting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cmdCancelPrinting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cmdCancelPrinting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancelPrinting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelPrinting.Location = new System.Drawing.Point(25, 507);
            this.cmdCancelPrinting.Name = "cmdCancelPrinting";
            this.cmdCancelPrinting.Size = new System.Drawing.Size(110, 73);
            this.cmdCancelPrinting.TabIndex = 18;
            this.cmdCancelPrinting.Text = "Cancel Print Jobs";
            this.cmdCancelPrinting.UseVisualStyleBackColor = false;
            this.cmdCancelPrinting.Click += new System.EventHandler(this.cmdCancelPrinting_Click);
            // 
            // lblPhotosLeft
            // 
            this.lblPhotosLeft.AutoSize = true;
            this.lblPhotosLeft.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhotosLeft.ForeColor = System.Drawing.Color.White;
            this.lblPhotosLeft.Location = new System.Drawing.Point(42, 466);
            this.lblPhotosLeft.Name = "lblPhotosLeft";
            this.lblPhotosLeft.Size = new System.Drawing.Size(74, 24);
            this.lblPhotosLeft.TabIndex = 17;
            this.lblPhotosLeft.Text = "label1";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(7, 442);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(152, 21);
            this.label20.TabIndex = 16;
            this.label20.Text = "Photos left to print";
            // 
            // lblPicCount
            // 
            this.lblPicCount.AutoSize = true;
            this.lblPicCount.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPicCount.ForeColor = System.Drawing.Color.White;
            this.lblPicCount.Location = new System.Drawing.Point(42, 395);
            this.lblPicCount.Name = "lblPicCount";
            this.lblPicCount.Size = new System.Drawing.Size(74, 24);
            this.lblPicCount.TabIndex = 15;
            this.lblPicCount.Text = "label1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(3, 367);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(152, 24);
            this.label18.TabIndex = 14;
            this.label18.Text = "Photos to Print";
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Black;
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblInfo.Font = new System.Drawing.Font("Century Gothic", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(6, 267);
            this.lblInfo.Multiline = true;
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(156, 59);
            this.lblInfo.TabIndex = 13;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(3, 220);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(74, 24);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "label1";
            // 
            // cmdToPrint
            // 
            this.cmdToPrint.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdToPrint.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdToPrint.FlatAppearance.BorderSize = 5;
            this.cmdToPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cmdToPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cmdToPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdToPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdToPrint.Location = new System.Drawing.Point(25, 650);
            this.cmdToPrint.Name = "cmdToPrint";
            this.cmdToPrint.Size = new System.Drawing.Size(110, 41);
            this.cmdToPrint.TabIndex = 2;
            this.cmdToPrint.Text = "Print";
            this.cmdToPrint.UseVisualStyleBackColor = false;
            this.cmdToPrint.Click += new System.EventHandler(this.cmdToPrint_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(3, 181);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(74, 24);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "label1";
            // 
            // cmdSettings
            // 
            this.cmdSettings.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdSettings.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdSettings.FlatAppearance.BorderSize = 5;
            this.cmdSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cmdSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cmdSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSettings.Location = new System.Drawing.Point(25, 700);
            this.cmdSettings.Name = "cmdSettings";
            this.cmdSettings.Size = new System.Drawing.Size(110, 41);
            this.cmdSettings.TabIndex = 1;
            this.cmdSettings.Text = "Settings";
            this.cmdSettings.UseVisualStyleBackColor = false;
            this.cmdSettings.Click += new System.EventHandler(this.cmdSettings_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Black;
            this.pnlTop.Controls.Add(this.pnlPicFinder);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(165, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1019, 53);
            this.pnlTop.TabIndex = 1;
            // 
            // pnlPicFinder
            // 
            this.pnlPicFinder.Controls.Add(this.label1);
            this.pnlPicFinder.Controls.Add(this.cmdFind);
            this.pnlPicFinder.Controls.Add(this.cboPicture);
            this.pnlPicFinder.Controls.Add(this.dtp1);
            this.pnlPicFinder.Controls.Add(this.label3);
            this.pnlPicFinder.Location = new System.Drawing.Point(3, 7);
            this.pnlPicFinder.Name = "pnlPicFinder";
            this.pnlPicFinder.Size = new System.Drawing.Size(893, 43);
            this.pnlPicFinder.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date to Print";
            // 
            // cmdFind
            // 
            this.cmdFind.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdFind.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdFind.FlatAppearance.BorderSize = 5;
            this.cmdFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cmdFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cmdFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFind.Location = new System.Drawing.Point(752, 3);
            this.cmdFind.Name = "cmdFind";
            this.cmdFind.Size = new System.Drawing.Size(138, 41);
            this.cmdFind.TabIndex = 11;
            this.cmdFind.Text = "Find Pictures";
            this.cmdFind.UseVisualStyleBackColor = false;
            this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
            // 
            // cboPicture
            // 
            this.cboPicture.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPicture.FormattingEnabled = true;
            this.cboPicture.Location = new System.Drawing.Point(506, 7);
            this.cboPicture.Name = "cboPicture";
            this.cboPicture.Size = new System.Drawing.Size(225, 26);
            this.cboPicture.TabIndex = 7;
            // 
            // dtp1
            // 
            this.dtp1.Font = new System.Drawing.Font("Century Gothic", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp1.Location = new System.Drawing.Point(143, 5);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(196, 30);
            this.dtp1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(345, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Picture to Print";
            // 
            // pnlPrint
            // 
            this.pnlPrint.BackColor = System.Drawing.Color.Black;
            this.pnlPrint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPrint.Location = new System.Drawing.Point(171, 122);
            this.pnlPrint.Name = "pnlPrint";
            this.pnlPrint.Size = new System.Drawing.Size(1080, 596);
            this.pnlPrint.TabIndex = 2;
            // 
            // cmdPrint
            // 
            this.cmdPrint.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdPrint.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdPrint.FlatAppearance.BorderSize = 5;
            this.cmdPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cmdPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPrint.Location = new System.Drawing.Point(888, 8);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(110, 41);
            this.cmdPrint.TabIndex = 8;
            this.cmdPrint.Text = "Print All";
            this.cmdPrint.UseVisualStyleBackColor = false;
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // cboPrinter
            // 
            this.cboPrinter.Font = new System.Drawing.Font("Century Gothic", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPrinter.FormattingEnabled = true;
            this.cboPrinter.Location = new System.Drawing.Point(79, 11);
            this.cboPrinter.Name = "cboPrinter";
            this.cboPrinter.Size = new System.Drawing.Size(370, 27);
            this.cboPrinter.TabIndex = 5;
            this.cboPrinter.SelectedIndexChanged += new System.EventHandler(this.cboPrinter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Printer";
            // 
            // tmTime
            // 
            this.tmTime.Enabled = true;
            this.tmTime.Interval = 1000;
            this.tmTime.Tick += new System.EventHandler(this.tmTime_Tick);
            // 
            // pnlSettings
            // 
            this.pnlSettings.BackColor = System.Drawing.Color.Black;
            this.pnlSettings.Controls.Add(this.groupBox5);
            this.pnlSettings.Controls.Add(this.groupBox4);
            this.pnlSettings.Controls.Add(this.groupBox3);
            this.pnlSettings.Controls.Add(this.groupBox2);
            this.pnlSettings.Controls.Add(this.groupBox1);
            this.pnlSettings.Location = new System.Drawing.Point(165, 53);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(955, 714);
            this.pnlSettings.TabIndex = 9;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtPicSize);
            this.groupBox5.Controls.Add(this.cmdPicSize);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(586, 593);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(252, 82);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Picture Size";
            // 
            // txtPicSize
            // 
            this.txtPicSize.Location = new System.Drawing.Point(6, 32);
            this.txtPicSize.Name = "txtPicSize";
            this.txtPicSize.Size = new System.Drawing.Size(95, 31);
            this.txtPicSize.TabIndex = 30;
            this.txtPicSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPicSize_KeyDown);
            // 
            // cmdPicSize
            // 
            this.cmdPicSize.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdPicSize.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdPicSize.FlatAppearance.BorderSize = 5;
            this.cmdPicSize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cmdPicSize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cmdPicSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPicSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPicSize.ForeColor = System.Drawing.Color.Black;
            this.cmdPicSize.Location = new System.Drawing.Point(118, 28);
            this.cmdPicSize.Name = "cmdPicSize";
            this.cmdPicSize.Size = new System.Drawing.Size(117, 41);
            this.cmdPicSize.TabIndex = 28;
            this.cmdPicSize.Text = "Save";
            this.cmdPicSize.UseVisualStyleBackColor = false;
            this.cmdPicSize.Click += new System.EventHandler(this.cmdPicSize_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtLocalSave);
            this.groupBox4.Controls.Add(this.cmdBrowseLocalSave);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(53, 565);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(442, 82);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Local Save Location";
            // 
            // txtLocalSave
            // 
            this.txtLocalSave.Location = new System.Drawing.Point(6, 32);
            this.txtLocalSave.Name = "txtLocalSave";
            this.txtLocalSave.Size = new System.Drawing.Size(315, 31);
            this.txtLocalSave.TabIndex = 30;
            // 
            // cmdBrowseLocalSave
            // 
            this.cmdBrowseLocalSave.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdBrowseLocalSave.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdBrowseLocalSave.FlatAppearance.BorderSize = 5;
            this.cmdBrowseLocalSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cmdBrowseLocalSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cmdBrowseLocalSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBrowseLocalSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBrowseLocalSave.ForeColor = System.Drawing.Color.Black;
            this.cmdBrowseLocalSave.Location = new System.Drawing.Point(327, 28);
            this.cmdBrowseLocalSave.Name = "cmdBrowseLocalSave";
            this.cmdBrowseLocalSave.Size = new System.Drawing.Size(100, 41);
            this.cmdBrowseLocalSave.TabIndex = 28;
            this.cmdBrowseLocalSave.Text = "Browse";
            this.cmdBrowseLocalSave.UseVisualStyleBackColor = false;
            this.cmdBrowseLocalSave.Click += new System.EventHandler(this.cmdBrowseLocalSave_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtWaitInterval);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.cmdSaveInterval);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(53, 477);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(497, 82);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wait Timer";
            // 
            // txtWaitInterval
            // 
            this.txtWaitInterval.Location = new System.Drawing.Point(262, 32);
            this.txtWaitInterval.Name = "txtWaitInterval";
            this.txtWaitInterval.Size = new System.Drawing.Size(72, 31);
            this.txtWaitInterval.TabIndex = 30;
            this.txtWaitInterval.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWaitInterval_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(244, 25);
            this.label14.TabIndex = 29;
            this.label14.Text = "Wait Interval in Seconds";
            // 
            // cmdSaveInterval
            // 
            this.cmdSaveInterval.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdSaveInterval.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdSaveInterval.FlatAppearance.BorderSize = 5;
            this.cmdSaveInterval.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cmdSaveInterval.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cmdSaveInterval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSaveInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSaveInterval.ForeColor = System.Drawing.Color.Black;
            this.cmdSaveInterval.Location = new System.Drawing.Point(350, 22);
            this.cmdSaveInterval.Name = "cmdSaveInterval";
            this.cmdSaveInterval.Size = new System.Drawing.Size(117, 41);
            this.cmdSaveInterval.TabIndex = 28;
            this.cmdSaveInterval.Text = "Save";
            this.cmdSaveInterval.UseVisualStyleBackColor = false;
            this.cmdSaveInterval.Click += new System.EventHandler(this.cmdSaveInterval_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdSaveFTP);
            this.groupBox2.Controls.Add(this.cmdCancelFTP);
            this.groupBox2.Controls.Add(this.txtFTPFamily);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtFTPAdult);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtFTPChild);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtFTPRF);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtFTPPort);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtFTPPasssword);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtFTPUsername);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtFTPHost);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(53, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 456);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FTP Details";
            // 
            // cmdSaveFTP
            // 
            this.cmdSaveFTP.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdSaveFTP.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdSaveFTP.FlatAppearance.BorderSize = 5;
            this.cmdSaveFTP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cmdSaveFTP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cmdSaveFTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSaveFTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSaveFTP.ForeColor = System.Drawing.Color.Black;
            this.cmdSaveFTP.Location = new System.Drawing.Point(136, 401);
            this.cmdSaveFTP.Name = "cmdSaveFTP";
            this.cmdSaveFTP.Size = new System.Drawing.Size(117, 41);
            this.cmdSaveFTP.TabIndex = 27;
            this.cmdSaveFTP.Text = "Save";
            this.cmdSaveFTP.UseVisualStyleBackColor = false;
            this.cmdSaveFTP.Click += new System.EventHandler(this.cmdSaveFTP_Click);
            // 
            // cmdCancelFTP
            // 
            this.cmdCancelFTP.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdCancelFTP.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdCancelFTP.FlatAppearance.BorderSize = 5;
            this.cmdCancelFTP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cmdCancelFTP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cmdCancelFTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancelFTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelFTP.ForeColor = System.Drawing.Color.Black;
            this.cmdCancelFTP.Location = new System.Drawing.Point(259, 401);
            this.cmdCancelFTP.Name = "cmdCancelFTP";
            this.cmdCancelFTP.Size = new System.Drawing.Size(119, 41);
            this.cmdCancelFTP.TabIndex = 26;
            this.cmdCancelFTP.Text = "Cancel";
            this.cmdCancelFTP.UseVisualStyleBackColor = false;
            this.cmdCancelFTP.Click += new System.EventHandler(this.cmdCancelFTP_Click);
            // 
            // txtFTPFamily
            // 
            this.txtFTPFamily.Location = new System.Drawing.Point(181, 348);
            this.txtFTPFamily.Name = "txtFTPFamily";
            this.txtFTPFamily.Size = new System.Drawing.Size(323, 33);
            this.txtFTPFamily.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 351);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 24);
            this.label13.TabIndex = 24;
            this.label13.Text = "Family Folder";
            // 
            // txtFTPAdult
            // 
            this.txtFTPAdult.Location = new System.Drawing.Point(181, 309);
            this.txtFTPAdult.Name = "txtFTPAdult";
            this.txtFTPAdult.Size = new System.Drawing.Size(323, 33);
            this.txtFTPAdult.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 312);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 24);
            this.label12.TabIndex = 22;
            this.label12.Text = "Adult Folder";
            // 
            // txtFTPChild
            // 
            this.txtFTPChild.Location = new System.Drawing.Point(181, 270);
            this.txtFTPChild.Name = "txtFTPChild";
            this.txtFTPChild.Size = new System.Drawing.Size(323, 33);
            this.txtFTPChild.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 273);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 24);
            this.label11.TabIndex = 20;
            this.label11.Text = "Child Folder";
            // 
            // txtFTPRF
            // 
            this.txtFTPRF.Location = new System.Drawing.Point(181, 231);
            this.txtFTPRF.Name = "txtFTPRF";
            this.txtFTPRF.Size = new System.Drawing.Size(323, 33);
            this.txtFTPRF.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 24);
            this.label10.TabIndex = 18;
            this.label10.Text = "Remote Folder";
            // 
            // txtFTPPort
            // 
            this.txtFTPPort.Location = new System.Drawing.Point(144, 157);
            this.txtFTPPort.Name = "txtFTPPort";
            this.txtFTPPort.Size = new System.Drawing.Size(75, 33);
            this.txtFTPPort.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "Port";
            // 
            // txtFTPPasssword
            // 
            this.txtFTPPasssword.Location = new System.Drawing.Point(143, 118);
            this.txtFTPPasssword.Name = "txtFTPPasssword";
            this.txtFTPPasssword.PasswordChar = '*';
            this.txtFTPPasssword.Size = new System.Drawing.Size(323, 33);
            this.txtFTPPasssword.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Password";
            // 
            // txtFTPUsername
            // 
            this.txtFTPUsername.Location = new System.Drawing.Point(144, 79);
            this.txtFTPUsername.Name = "txtFTPUsername";
            this.txtFTPUsername.Size = new System.Drawing.Size(323, 33);
            this.txtFTPUsername.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Username";
            // 
            // txtFTPHost
            // 
            this.txtFTPHost.Location = new System.Drawing.Point(144, 40);
            this.txtFTPHost.Name = "txtFTPHost";
            this.txtFTPHost.Size = new System.Drawing.Size(323, 33);
            this.txtFTPHost.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Host/Server";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.cmdSaveNewPhoto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAddDescription);
            this.groupBox1.Controls.Add(this.txtAddPhoto);
            this.groupBox1.Controls.Add(this.lstdescription);
            this.groupBox1.Controls.Add(this.lstNames);
            this.groupBox1.Controls.Add(this.cmdDeletePhoto);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(586, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 576);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Photo Setups";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(181, 72);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(111, 22);
            this.label17.TabIndex = 13;
            this.label17.Text = "Description";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(38, 72);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 22);
            this.label16.TabIndex = 12;
            this.label16.Text = "Server";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 22);
            this.label15.TabIndex = 11;
            this.label15.Text = "Name on";
            // 
            // cmdSaveNewPhoto
            // 
            this.cmdSaveNewPhoto.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdSaveNewPhoto.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdSaveNewPhoto.FlatAppearance.BorderSize = 5;
            this.cmdSaveNewPhoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cmdSaveNewPhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cmdSaveNewPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSaveNewPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSaveNewPhoto.ForeColor = System.Drawing.Color.Black;
            this.cmdSaveNewPhoto.Location = new System.Drawing.Point(74, 522);
            this.cmdSaveNewPhoto.Name = "cmdSaveNewPhoto";
            this.cmdSaveNewPhoto.Size = new System.Drawing.Size(189, 41);
            this.cmdSaveNewPhoto.TabIndex = 10;
            this.cmdSaveNewPhoto.Text = "Add Photo";
            this.cmdSaveNewPhoto.UseVisualStyleBackColor = false;
            this.cmdSaveNewPhoto.Click += new System.EventHandler(this.cmdSaveNewPhoto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 462);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Photo Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Photo Name";
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.Location = new System.Drawing.Point(10, 486);
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.Size = new System.Drawing.Size(323, 30);
            this.txtAddDescription.TabIndex = 7;
            this.txtAddDescription.TextChanged += new System.EventHandler(this.txtAddDescription_TextChanged);
            this.txtAddDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddDescription_KeyDown);
            // 
            // txtAddPhoto
            // 
            this.txtAddPhoto.Location = new System.Drawing.Point(8, 429);
            this.txtAddPhoto.Name = "txtAddPhoto";
            this.txtAddPhoto.Size = new System.Drawing.Size(323, 30);
            this.txtAddPhoto.TabIndex = 6;
            this.txtAddPhoto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddPhoto_KeyDown);
            // 
            // lstdescription
            // 
            this.lstdescription.FormattingEnabled = true;
            this.lstdescription.ItemHeight = 21;
            this.lstdescription.Location = new System.Drawing.Point(143, 99);
            this.lstdescription.Name = "lstdescription";
            this.lstdescription.Size = new System.Drawing.Size(190, 256);
            this.lstdescription.TabIndex = 5;
            this.lstdescription.SelectedIndexChanged += new System.EventHandler(this.lstdescription_SelectedIndexChanged);
            // 
            // lstNames
            // 
            this.lstNames.FormattingEnabled = true;
            this.lstNames.ItemHeight = 21;
            this.lstNames.Location = new System.Drawing.Point(17, 99);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(120, 256);
            this.lstNames.TabIndex = 4;
            this.lstNames.SelectedIndexChanged += new System.EventHandler(this.lstNames_SelectedIndexChanged);
            // 
            // cmdDeletePhoto
            // 
            this.cmdDeletePhoto.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdDeletePhoto.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdDeletePhoto.FlatAppearance.BorderSize = 5;
            this.cmdDeletePhoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cmdDeletePhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cmdDeletePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDeletePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDeletePhoto.ForeColor = System.Drawing.Color.Black;
            this.cmdDeletePhoto.Location = new System.Drawing.Point(74, 361);
            this.cmdDeletePhoto.Name = "cmdDeletePhoto";
            this.cmdDeletePhoto.Size = new System.Drawing.Size(189, 41);
            this.cmdDeletePhoto.TabIndex = 3;
            this.cmdDeletePhoto.Text = "Delete Selected";
            this.cmdDeletePhoto.UseVisualStyleBackColor = false;
            this.cmdDeletePhoto.Click += new System.EventHandler(this.cmdDeletePhoto_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Black;
            this.pnlBottom.Controls.Add(this.pnlPrinter);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(165, 699);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1019, 60);
            this.pnlBottom.TabIndex = 10;
            // 
            // pnlPrinter
            // 
            this.pnlPrinter.Controls.Add(this.label19);
            this.pnlPrinter.Controls.Add(this.cboPaperSize);
            this.pnlPrinter.Controls.Add(this.label2);
            this.pnlPrinter.Controls.Add(this.cboPrinter);
            this.pnlPrinter.Controls.Add(this.cmdPrint);
            this.pnlPrinter.Location = new System.Drawing.Point(6, 6);
            this.pnlPrinter.Name = "pnlPrinter";
            this.pnlPrinter.Size = new System.Drawing.Size(1001, 57);
            this.pnlPrinter.TabIndex = 9;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Goldenrod;
            this.label19.Location = new System.Drawing.Point(448, 11);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(117, 25);
            this.label19.TabIndex = 10;
            this.label19.Text = "Paper Size";
            // 
            // cboPaperSize
            // 
            this.cboPaperSize.Font = new System.Drawing.Font("Century Gothic", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPaperSize.FormattingEnabled = true;
            this.cboPaperSize.Location = new System.Drawing.Point(566, 12);
            this.cboPaperSize.Name = "cboPaperSize";
            this.cboPaperSize.Size = new System.Drawing.Size(316, 27);
            this.cboPaperSize.TabIndex = 9;
            this.cboPaperSize.SelectedIndexChanged += new System.EventHandler(this.cboPaperSize_SelectedIndexChanged);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 759);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlPrint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Auto Print ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlPicFinder.ResumeLayout(false);
            this.pnlPicFinder.PerformLayout();
            this.pnlSettings.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlPrinter.ResumeLayout(false);
            this.pnlPrinter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button cmdSettings;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel pnlPrint;
        private System.Windows.Forms.Timer tmTime;
        private System.Windows.Forms.Button cmdPrint;
        private System.Windows.Forms.ComboBox cboPicture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPrinter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Button cmdToPrint;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Button cmdFind;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdDeletePhoto;
        private System.Windows.Forms.ListBox lstdescription;
        private System.Windows.Forms.ListBox lstNames;
        private System.Windows.Forms.Button cmdSaveNewPhoto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddDescription;
        private System.Windows.Forms.TextBox txtAddPhoto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdSaveFTP;
        private System.Windows.Forms.Button cmdCancelFTP;
        private System.Windows.Forms.TextBox txtFTPFamily;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFTPAdult;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFTPChild;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFTPRF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFTPPort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFTPPasssword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFTPUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFTPHost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtLocalSave;
        private System.Windows.Forms.Button cmdBrowseLocalSave;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtWaitInterval;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button cmdSaveInterval;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtPicSize;
        private System.Windows.Forms.Button cmdPicSize;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel pnlPicFinder;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlPrinter;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox lblInfo;
        private System.Windows.Forms.Label lblPicCount;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cboPaperSize;
        private System.Windows.Forms.Label lblPhotosLeft;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button cmdCancelPrinting;
    }
}

