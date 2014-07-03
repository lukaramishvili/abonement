namespace ManagementSystem
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.mainToolbar = new System.Windows.Forms.ToolStrip();
            this.btnAddPerson = new System.Windows.Forms.ToolStripButton();
            this.btnRemovePerson = new System.Windows.Forms.ToolStripButton();
            this.btnAddAbonement = new System.Windows.Forms.ToolStripButton();
            this.btnSaveAllData = new System.Windows.Forms.ToolStripButton();
            this.btnTextSearch = new System.Windows.Forms.ToolStripButton();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.main_hsplit = new System.Windows.Forms.SplitContainer();
            this.persons_lv = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ident = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.balance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDayLoad = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.resDayLoad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_dayload_hour = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_dayload_day = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTodayStats = new System.Windows.Forms.Button();
            this.btnShowAllPersons = new System.Windows.Forms.Button();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.stat_today_hour = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAllTimeStats = new System.Windows.Forms.Button();
            this.stat_anyday_end = new System.Windows.Forms.DateTimePicker();
            this.stat_anyday_start = new System.Windows.Forms.DateTimePicker();
            this.stat_anyday_date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bottom_vsplit = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.abonements_lv = new System.Windows.Forms.ListView();
            this.abid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.abstart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.abend = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddAttendance = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.attendances_lv = new System.Windows.Forms.ListView();
            this.attid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.attday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.atttime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuAttendance = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemAttended = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatus = new System.Windows.Forms.StatusStrip();
            this.labelLoginStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTodayCount = new System.Windows.Forms.TextBox();
            this.mainToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_hsplit)).BeginInit();
            this.main_hsplit.Panel1.SuspendLayout();
            this.main_hsplit.Panel2.SuspendLayout();
            this.main_hsplit.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottom_vsplit)).BeginInit();
            this.bottom_vsplit.Panel1.SuspendLayout();
            this.bottom_vsplit.Panel2.SuspendLayout();
            this.bottom_vsplit.SuspendLayout();
            this.menuAttendance.SuspendLayout();
            this.mainStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainToolbar
            // 
            this.mainToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddPerson,
            this.btnRemovePerson,
            this.btnAddAbonement,
            this.btnSaveAllData,
            this.btnTextSearch,
            this.txtSearch});
            this.mainToolbar.Location = new System.Drawing.Point(0, 0);
            this.mainToolbar.Name = "mainToolbar";
            this.mainToolbar.Padding = new System.Windows.Forms.Padding(4);
            this.mainToolbar.Size = new System.Drawing.Size(1006, 31);
            this.mainToolbar.TabIndex = 1;
            this.mainToolbar.Text = "toolStrip1";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddPerson.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPerson.Image")));
            this.btnAddPerson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(114, 20);
            this.btnAddPerson.Text = "პიროვნების დამატება";
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnRemovePerson
            // 
            this.btnRemovePerson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRemovePerson.Image = ((System.Drawing.Image)(resources.GetObject("btnRemovePerson.Image")));
            this.btnRemovePerson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemovePerson.Name = "btnRemovePerson";
            this.btnRemovePerson.Size = new System.Drawing.Size(100, 20);
            this.btnRemovePerson.Text = "პიროვნების წაშლა";
            this.btnRemovePerson.Click += new System.EventHandler(this.btnRemovePerson_Click);
            // 
            // btnAddAbonement
            // 
            this.btnAddAbonement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddAbonement.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAbonement.Image")));
            this.btnAddAbonement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddAbonement.Name = "btnAddAbonement";
            this.btnAddAbonement.Size = new System.Drawing.Size(116, 20);
            this.btnAddAbonement.Text = "აბონემენტის დამატება";
            this.btnAddAbonement.Click += new System.EventHandler(this.btnAddAbonement_Click);
            // 
            // btnSaveAllData
            // 
            this.btnSaveAllData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSaveAllData.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAllData.Image")));
            this.btnSaveAllData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAllData.Name = "btnSaveAllData";
            this.btnSaveAllData.Size = new System.Drawing.Size(106, 20);
            this.btnSaveAllData.Text = "მონაცემების შენახვა";
            this.btnSaveAllData.Click += new System.EventHandler(this.btnSaveAllData_Click);
            // 
            // btnTextSearch
            // 
            this.btnTextSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnTextSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnTextSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnTextSearch.Image")));
            this.btnTextSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTextSearch.Name = "btnTextSearch";
            this.btnTextSearch.Size = new System.Drawing.Size(36, 20);
            this.btnTextSearch.Text = "ძიება";
            this.btnTextSearch.Click += new System.EventHandler(this.btnTextSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(160, 23);
            this.txtSearch.Text = "ძიება (ID, სახელი, გვარი)..";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // main_hsplit
            // 
            this.main_hsplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_hsplit.Location = new System.Drawing.Point(0, 31);
            this.main_hsplit.Name = "main_hsplit";
            this.main_hsplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // main_hsplit.Panel1
            // 
            this.main_hsplit.Panel1.Controls.Add(this.persons_lv);
            this.main_hsplit.Panel1.Controls.Add(this.panel1);
            // 
            // main_hsplit.Panel2
            // 
            this.main_hsplit.Panel2.Controls.Add(this.bottom_vsplit);
            this.main_hsplit.Size = new System.Drawing.Size(1006, 450);
            this.main_hsplit.SplitterDistance = 253;
            this.main_hsplit.TabIndex = 3;
            // 
            // persons_lv
            // 
            this.persons_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.ident,
            this.name,
            this.age,
            this.address,
            this.phone,
            this.balance});
            this.persons_lv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.persons_lv.FullRowSelect = true;
            this.persons_lv.HideSelection = false;
            this.persons_lv.Location = new System.Drawing.Point(0, 100);
            this.persons_lv.MultiSelect = false;
            this.persons_lv.Name = "persons_lv";
            this.persons_lv.Size = new System.Drawing.Size(1006, 153);
            this.persons_lv.TabIndex = 4;
            this.persons_lv.UseCompatibleStateImageBehavior = false;
            this.persons_lv.View = System.Windows.Forms.View.Details;
            this.persons_lv.SelectedIndexChanged += new System.EventHandler(this.persons_lv_SelectedIndexChanged);
            this.persons_lv.DoubleClick += new System.EventHandler(this.persons_lv_DoubleClick);
            // 
            // id
            // 
            this.id.Tag = "id";
            this.id.Text = "ID";
            this.id.Width = 37;
            // 
            // ident
            // 
            this.ident.Tag = "ident";
            this.ident.Text = "პირადი ნომერი";
            this.ident.Width = 85;
            // 
            // name
            // 
            this.name.Tag = "name";
            this.name.Text = "სახელი და გვარი";
            this.name.Width = 95;
            // 
            // age
            // 
            this.age.Tag = "age";
            this.age.Text = "ასაკი";
            // 
            // address
            // 
            this.address.Tag = "address";
            this.address.Text = "მისამართი";
            this.address.Width = 67;
            // 
            // phone
            // 
            this.phone.Tag = "phone";
            this.phone.Text = "ტელ.";
            // 
            // balance
            // 
            this.balance.Tag = "balance";
            this.balance.Text = "ბალანსი";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 100);
            this.panel1.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDayLoad);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.resDayLoad);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cb_dayload_hour);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cb_dayload_day);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(361, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "დღეების დატვირთვა";
            // 
            // btnDayLoad
            // 
            this.btnDayLoad.Location = new System.Drawing.Point(6, 52);
            this.btnDayLoad.Name = "btnDayLoad";
            this.btnDayLoad.Size = new System.Drawing.Size(53, 23);
            this.btnDayLoad.TabIndex = 8;
            this.btnDayLoad.Text = "ძიება";
            this.btnDayLoad.UseVisualStyleBackColor = true;
            this.btnDayLoad.Click += new System.EventHandler(this.btnDayLoad_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(196, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "ბავშვი";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(65, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "ჩაწერილია";
            // 
            // resDayLoad
            // 
            this.resDayLoad.Enabled = false;
            this.resDayLoad.Location = new System.Drawing.Point(134, 54);
            this.resDayLoad.Name = "resDayLoad";
            this.resDayLoad.Size = new System.Drawing.Size(52, 20);
            this.resDayLoad.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(177, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "საათი";
            // 
            // cb_dayload_hour
            // 
            this.cb_dayload_hour.CustomFormat = "HH:00 სთ";
            this.cb_dayload_hour.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cb_dayload_hour.Location = new System.Drawing.Point(213, 25);
            this.cb_dayload_hour.Name = "cb_dayload_hour";
            this.cb_dayload_hour.ShowUpDown = true;
            this.cb_dayload_hour.Size = new System.Drawing.Size(65, 20);
            this.cb_dayload_hour.TabIndex = 12;
            this.cb_dayload_hour.ValueChanged += new System.EventHandler(this.cb_dayload_hour_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "დღე";
            // 
            // cb_dayload_day
            // 
            this.cb_dayload_day.FormattingEnabled = true;
            this.cb_dayload_day.Items.AddRange(new object[] {
            "ორშაბათი",
            "სამშაბათი",
            "ოთხშაბათი",
            "ხუთშაბათი",
            "პარასკევი",
            "შაბათი"});
            this.cb_dayload_day.Location = new System.Drawing.Point(44, 25);
            this.cb_dayload_day.Name = "cb_dayload_day";
            this.cb_dayload_day.Size = new System.Drawing.Size(121, 21);
            this.cb_dayload_day.TabIndex = 0;
            this.cb_dayload_day.SelectedIndexChanged += new System.EventHandler(this.cb_dayload_day_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtTodayCount);
            this.groupBox2.Controls.Add(this.btnTodayStats);
            this.groupBox2.Controls.Add(this.btnShowAllPersons);
            this.groupBox2.Controls.Add(this.btnClearSearch);
            this.groupBox2.Controls.Add(this.stat_today_hour);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(672, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "დღის სტატისტიკა";
            // 
            // btnTodayStats
            // 
            this.btnTodayStats.Location = new System.Drawing.Point(253, 16);
            this.btnTodayStats.Name = "btnTodayStats";
            this.btnTodayStats.Size = new System.Drawing.Size(75, 23);
            this.btnTodayStats.TabIndex = 11;
            this.btnTodayStats.Text = "ძიება";
            this.btnTodayStats.UseVisualStyleBackColor = true;
            this.btnTodayStats.Click += new System.EventHandler(this.btnTodayStats_Click);
            // 
            // btnShowAllPersons
            // 
            this.btnShowAllPersons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnShowAllPersons.Location = new System.Drawing.Point(6, 71);
            this.btnShowAllPersons.Name = "btnShowAllPersons";
            this.btnShowAllPersons.Size = new System.Drawing.Size(119, 23);
            this.btnShowAllPersons.TabIndex = 10;
            this.btnShowAllPersons.Text = "ყველას ჩვენება";
            this.btnShowAllPersons.UseVisualStyleBackColor = true;
            this.btnShowAllPersons.Click += new System.EventHandler(this.btnShowAllPersons_Click);
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.ForeColor = System.Drawing.Color.Red;
            this.btnClearSearch.Location = new System.Drawing.Point(139, 71);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(119, 23);
            this.btnClearSearch.TabIndex = 9;
            this.btnClearSearch.Text = "ძიების გასუფთავება";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // stat_today_hour
            // 
            this.stat_today_hour.CustomFormat = "HH:00 სთ";
            this.stat_today_hour.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.stat_today_hour.Location = new System.Drawing.Point(166, 19);
            this.stat_today_hour.Name = "stat_today_hour";
            this.stat_today_hour.ShowUpDown = true;
            this.stat_today_hour.Size = new System.Drawing.Size(66, 20);
            this.stat_today_hour.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "-ზე";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "რამდენი ბავშვი დაესწრო/მოვიდა";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAllTimeStats);
            this.groupBox1.Controls.Add(this.stat_anyday_end);
            this.groupBox1.Controls.Add(this.stat_anyday_start);
            this.groupBox1.Controls.Add(this.stat_anyday_date);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "სტატისტიკა";
            // 
            // btnAllTimeStats
            // 
            this.btnAllTimeStats.Location = new System.Drawing.Point(270, 52);
            this.btnAllTimeStats.Name = "btnAllTimeStats";
            this.btnAllTimeStats.Size = new System.Drawing.Size(75, 23);
            this.btnAllTimeStats.TabIndex = 7;
            this.btnAllTimeStats.Text = "ძიება";
            this.btnAllTimeStats.UseVisualStyleBackColor = true;
            this.btnAllTimeStats.Click += new System.EventHandler(this.btnAllTimeStats_Click);
            // 
            // stat_anyday_end
            // 
            this.stat_anyday_end.CustomFormat = "HH:00 სთ";
            this.stat_anyday_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.stat_anyday_end.Location = new System.Drawing.Point(145, 54);
            this.stat_anyday_end.Name = "stat_anyday_end";
            this.stat_anyday_end.ShowUpDown = true;
            this.stat_anyday_end.Size = new System.Drawing.Size(80, 20);
            this.stat_anyday_end.TabIndex = 6;
            // 
            // stat_anyday_start
            // 
            this.stat_anyday_start.CustomFormat = "HH:00 სთ";
            this.stat_anyday_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.stat_anyday_start.Location = new System.Drawing.Point(12, 54);
            this.stat_anyday_start.Name = "stat_anyday_start";
            this.stat_anyday_start.ShowUpDown = true;
            this.stat_anyday_start.Size = new System.Drawing.Size(80, 20);
            this.stat_anyday_start.TabIndex = 5;
            // 
            // stat_anyday_date
            // 
            this.stat_anyday_date.Location = new System.Drawing.Point(141, 20);
            this.stat_anyday_date.Name = "stat_anyday_date";
            this.stat_anyday_date.Size = new System.Drawing.Size(200, 20);
            this.stat_anyday_date.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "-მდე";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "-დან";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "-ს";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "რამდენი ბავშვია ჩაწერილი";
            // 
            // bottom_vsplit
            // 
            this.bottom_vsplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottom_vsplit.Location = new System.Drawing.Point(0, 0);
            this.bottom_vsplit.Name = "bottom_vsplit";
            // 
            // bottom_vsplit.Panel1
            // 
            this.bottom_vsplit.Panel1.Controls.Add(this.label1);
            this.bottom_vsplit.Panel1.Controls.Add(this.abonements_lv);
            this.bottom_vsplit.Panel1.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            // 
            // bottom_vsplit.Panel2
            // 
            this.bottom_vsplit.Panel2.Controls.Add(this.btnAddAttendance);
            this.bottom_vsplit.Panel2.Controls.Add(this.label2);
            this.bottom_vsplit.Panel2.Controls.Add(this.attendances_lv);
            this.bottom_vsplit.Panel2.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.bottom_vsplit.Size = new System.Drawing.Size(1006, 193);
            this.bottom_vsplit.SplitterDistance = 540;
            this.bottom_vsplit.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "პიროვნების მოსვლის დრო";
            // 
            // abonements_lv
            // 
            this.abonements_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.abid,
            this.abstart,
            this.abend});
            this.abonements_lv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.abonements_lv.FullRowSelect = true;
            this.abonements_lv.HideSelection = false;
            this.abonements_lv.Location = new System.Drawing.Point(0, 25);
            this.abonements_lv.Name = "abonements_lv";
            this.abonements_lv.Size = new System.Drawing.Size(540, 168);
            this.abonements_lv.TabIndex = 1;
            this.abonements_lv.UseCompatibleStateImageBehavior = false;
            this.abonements_lv.View = System.Windows.Forms.View.Details;
            this.abonements_lv.SelectedIndexChanged += new System.EventHandler(this.abonements_lv_SelectedIndexChanged);
            this.abonements_lv.DoubleClick += new System.EventHandler(this.abonements_lv_DoubleClick);
            // 
            // abid
            // 
            this.abid.Tag = "id";
            this.abid.Text = "ID";
            this.abid.Width = 34;
            // 
            // abstart
            // 
            this.abstart.Tag = "start";
            this.abstart.Text = "დაწყების თარიღი";
            this.abstart.Width = 165;
            // 
            // abend
            // 
            this.abend.Tag = "end";
            this.abend.Text = "დასრულების თარიღი";
            this.abend.Width = 153;
            // 
            // btnAddAttendance
            // 
            this.btnAddAttendance.Location = new System.Drawing.Point(325, 0);
            this.btnAddAttendance.Name = "btnAddAttendance";
            this.btnAddAttendance.Size = new System.Drawing.Size(134, 22);
            this.btnAddAttendance.TabIndex = 4;
            this.btnAddAttendance.Text = "დასწრების დამატება";
            this.btnAddAttendance.UseVisualStyleBackColor = true;
            this.btnAddAttendance.Click += new System.EventHandler(this.btnAddAttendance_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "დასწრება";
            // 
            // attendances_lv
            // 
            this.attendances_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.attid,
            this.attday,
            this.atttime});
            this.attendances_lv.ContextMenuStrip = this.menuAttendance;
            this.attendances_lv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendances_lv.FullRowSelect = true;
            this.attendances_lv.HideSelection = false;
            this.attendances_lv.Location = new System.Drawing.Point(0, 25);
            this.attendances_lv.Name = "attendances_lv";
            this.attendances_lv.Size = new System.Drawing.Size(462, 168);
            this.attendances_lv.TabIndex = 0;
            this.attendances_lv.UseCompatibleStateImageBehavior = false;
            this.attendances_lv.View = System.Windows.Forms.View.Details;
            this.attendances_lv.SelectedIndexChanged += new System.EventHandler(this.attendances_lv_SelectedIndexChanged);
            this.attendances_lv.DoubleClick += new System.EventHandler(this.attendances_lv_DoubleClick);
            // 
            // attid
            // 
            this.attid.Tag = "id";
            this.attid.Text = "ID";
            // 
            // attday
            // 
            this.attday.Tag = "day";
            this.attday.Text = "თარიღი";
            this.attday.Width = 140;
            // 
            // atttime
            // 
            this.atttime.Tag = "time";
            this.atttime.Text = "დრო";
            // 
            // menuAttendance
            // 
            this.menuAttendance.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAttended});
            this.menuAttendance.Name = "menuAttendance";
            this.menuAttendance.Size = new System.Drawing.Size(118, 26);
            // 
            // menuItemAttended
            // 
            this.menuItemAttended.Name = "menuItemAttended";
            this.menuItemAttended.Size = new System.Drawing.Size(117, 22);
            this.menuItemAttended.Text = "დაესწრო";
            this.menuItemAttended.Click += new System.EventHandler(this.menuItemAttended_Click);
            // 
            // mainStatus
            // 
            this.mainStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelLoginStatus});
            this.mainStatus.Location = new System.Drawing.Point(0, 459);
            this.mainStatus.Name = "mainStatus";
            this.mainStatus.Size = new System.Drawing.Size(1006, 22);
            this.mainStatus.TabIndex = 4;
            this.mainStatus.Text = "statusStrip1";
            // 
            // labelLoginStatus
            // 
            this.labelLoginStatus.Name = "labelLoginStatus";
            this.labelLoginStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(294, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "ბავშვი";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(144, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "დაესწრო/მოვიდა";
            // 
            // txtTodayCount
            // 
            this.txtTodayCount.Enabled = false;
            this.txtTodayCount.Location = new System.Drawing.Point(238, 45);
            this.txtTodayCount.Name = "txtTodayCount";
            this.txtTodayCount.Size = new System.Drawing.Size(52, 20);
            this.txtTodayCount.TabIndex = 17;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 481);
            this.Controls.Add(this.mainStatus);
            this.Controls.Add(this.main_hsplit);
            this.Controls.Add(this.mainToolbar);
            this.Name = "Main";
            this.Text = "Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.mainToolbar.ResumeLayout(false);
            this.mainToolbar.PerformLayout();
            this.main_hsplit.Panel1.ResumeLayout(false);
            this.main_hsplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.main_hsplit)).EndInit();
            this.main_hsplit.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.bottom_vsplit.Panel1.ResumeLayout(false);
            this.bottom_vsplit.Panel1.PerformLayout();
            this.bottom_vsplit.Panel2.ResumeLayout(false);
            this.bottom_vsplit.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottom_vsplit)).EndInit();
            this.bottom_vsplit.ResumeLayout(false);
            this.menuAttendance.ResumeLayout(false);
            this.mainStatus.ResumeLayout(false);
            this.mainStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip mainToolbar;
        private System.Windows.Forms.SplitContainer main_hsplit;
        private System.Windows.Forms.ToolStripButton btnAddPerson;
        private System.Windows.Forms.ToolStripButton btnAddAbonement;
        private System.Windows.Forms.ContextMenuStrip menuAttendance;
        private System.Windows.Forms.ToolStripMenuItem menuItemAttended;
        private System.Windows.Forms.SplitContainer bottom_vsplit;
        private System.Windows.Forms.ListView abonements_lv;
        private System.Windows.Forms.ColumnHeader abid;
        private System.Windows.Forms.ColumnHeader abstart;
        private System.Windows.Forms.ColumnHeader abend;
        private System.Windows.Forms.ListView attendances_lv;
        private System.Windows.Forms.ColumnHeader attid;
        private System.Windows.Forms.ColumnHeader attday;
        private System.Windows.Forms.ColumnHeader atttime;
        private System.Windows.Forms.StatusStrip mainStatus;
        private System.Windows.Forms.ToolStripStatusLabel labelLoginStatus;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker stat_anyday_end;
        private System.Windows.Forms.DateTimePicker stat_anyday_start;
        private System.Windows.Forms.DateTimePicker stat_anyday_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShowAllPersons;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.DateTimePicker stat_today_hour;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTodayStats;
        private System.Windows.Forms.Button btnAllTimeStats;
        private System.Windows.Forms.ToolStripButton btnSaveAllData;
        private System.Windows.Forms.ListView persons_lv;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader ident;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader age;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader phone;
        private System.Windows.Forms.ColumnHeader balance;
        private System.Windows.Forms.Button btnAddAttendance;
        private System.Windows.Forms.ToolStripButton btnTextSearch;
        private System.Windows.Forms.ToolStripButton btnRemovePerson;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox resDayLoad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker cb_dayload_hour;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_dayload_day;
        private System.Windows.Forms.Button btnDayLoad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTodayCount;

    }
}

