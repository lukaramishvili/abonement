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
            this.btnAddAbonement = new System.Windows.Forms.ToolStripButton();
            this.main_hsplit = new System.Windows.Forms.SplitContainer();
            this.persons_lv = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ident = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.balance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bottom_vsplit = new System.Windows.Forms.SplitContainer();
            this.aboniments_lv = new System.Windows.Forms.ListView();
            this.abid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.abstart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.abend = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.attendances_lv = new System.Windows.Forms.ListView();
            this.attid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.attday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.attattended = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuAttendance = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemAttended = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_hsplit)).BeginInit();
            this.main_hsplit.Panel1.SuspendLayout();
            this.main_hsplit.Panel2.SuspendLayout();
            this.main_hsplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottom_vsplit)).BeginInit();
            this.bottom_vsplit.Panel1.SuspendLayout();
            this.bottom_vsplit.Panel2.SuspendLayout();
            this.bottom_vsplit.SuspendLayout();
            this.menuAttendance.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainToolbar
            // 
            this.mainToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddPerson,
            this.btnAddAbonement});
            this.mainToolbar.Location = new System.Drawing.Point(0, 0);
            this.mainToolbar.Name = "mainToolbar";
            this.mainToolbar.Padding = new System.Windows.Forms.Padding(4);
            this.mainToolbar.Size = new System.Drawing.Size(671, 30);
            this.mainToolbar.TabIndex = 1;
            this.mainToolbar.Text = "toolStrip1";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddPerson.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPerson.Image")));
            this.btnAddPerson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(114, 19);
            this.btnAddPerson.Text = "პიროვნების დამატება";
            // 
            // btnAddAbonement
            // 
            this.btnAddAbonement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddAbonement.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAbonement.Image")));
            this.btnAddAbonement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddAbonement.Name = "btnAddAbonement";
            this.btnAddAbonement.Size = new System.Drawing.Size(116, 19);
            this.btnAddAbonement.Text = "აბონემენტის დამატება";
            // 
            // main_hsplit
            // 
            this.main_hsplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_hsplit.Location = new System.Drawing.Point(0, 30);
            this.main_hsplit.Name = "main_hsplit";
            this.main_hsplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // main_hsplit.Panel1
            // 
            this.main_hsplit.Panel1.Controls.Add(this.persons_lv);
            // 
            // main_hsplit.Panel2
            // 
            this.main_hsplit.Panel2.Controls.Add(this.bottom_vsplit);
            this.main_hsplit.Size = new System.Drawing.Size(671, 331);
            this.main_hsplit.SplitterDistance = 187;
            this.main_hsplit.TabIndex = 3;
            // 
            // persons_lv
            // 
            this.persons_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.ident,
            this.name,
            this.age,
            this.count,
            this.address,
            this.phone,
            this.balance});
            this.persons_lv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.persons_lv.FullRowSelect = true;
            this.persons_lv.Location = new System.Drawing.Point(0, 0);
            this.persons_lv.MultiSelect = false;
            this.persons_lv.Name = "persons_lv";
            this.persons_lv.Size = new System.Drawing.Size(671, 187);
            this.persons_lv.TabIndex = 2;
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
            // count
            // 
            this.count.Tag = "count";
            this.count.Text = "აბონემენტები";
            this.count.Width = 75;
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
            // bottom_vsplit
            // 
            this.bottom_vsplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottom_vsplit.Location = new System.Drawing.Point(0, 0);
            this.bottom_vsplit.Name = "bottom_vsplit";
            // 
            // bottom_vsplit.Panel1
            // 
            this.bottom_vsplit.Panel1.Controls.Add(this.aboniments_lv);
            // 
            // bottom_vsplit.Panel2
            // 
            this.bottom_vsplit.Panel2.Controls.Add(this.attendances_lv);
            this.bottom_vsplit.Size = new System.Drawing.Size(671, 140);
            this.bottom_vsplit.SplitterDistance = 361;
            this.bottom_vsplit.TabIndex = 0;
            // 
            // aboniments_lv
            // 
            this.aboniments_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.abid,
            this.abstart,
            this.abend});
            this.aboniments_lv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboniments_lv.FullRowSelect = true;
            this.aboniments_lv.Location = new System.Drawing.Point(0, 0);
            this.aboniments_lv.Name = "aboniments_lv";
            this.aboniments_lv.Size = new System.Drawing.Size(361, 140);
            this.aboniments_lv.TabIndex = 1;
            this.aboniments_lv.UseCompatibleStateImageBehavior = false;
            this.aboniments_lv.View = System.Windows.Forms.View.Details;
            this.aboniments_lv.SelectedIndexChanged += new System.EventHandler(this.aboniments_lv_SelectedIndexChanged);
            this.aboniments_lv.DoubleClick += new System.EventHandler(this.aboniments_lv_DoubleClick);
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
            // attendances_lv
            // 
            this.attendances_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.attid,
            this.attday,
            this.attattended});
            this.attendances_lv.ContextMenuStrip = this.menuAttendance;
            this.attendances_lv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendances_lv.FullRowSelect = true;
            this.attendances_lv.Location = new System.Drawing.Point(0, 0);
            this.attendances_lv.Name = "attendances_lv";
            this.attendances_lv.Size = new System.Drawing.Size(306, 140);
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
            // 
            // attattended
            // 
            this.attattended.Tag = "attended";
            this.attattended.Text = "დაესწრო";
            // 
            // menuAttendance
            // 
            this.menuAttendance.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAttended});
            this.menuAttendance.Name = "menuAttendance";
            this.menuAttendance.Size = new System.Drawing.Size(153, 48);
            // 
            // menuItemAttended
            // 
            this.menuItemAttended.Name = "menuItemAttended";
            this.menuItemAttended.Size = new System.Drawing.Size(152, 22);
            this.menuItemAttended.Text = "დაესწრო";
            this.menuItemAttended.Click += new System.EventHandler(this.menuItemAttended_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 361);
            this.Controls.Add(this.main_hsplit);
            this.Controls.Add(this.mainToolbar);
            this.Name = "Main";
            this.Text = "Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.mainToolbar.ResumeLayout(false);
            this.mainToolbar.PerformLayout();
            this.main_hsplit.Panel1.ResumeLayout(false);
            this.main_hsplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.main_hsplit)).EndInit();
            this.main_hsplit.ResumeLayout(false);
            this.bottom_vsplit.Panel1.ResumeLayout(false);
            this.bottom_vsplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bottom_vsplit)).EndInit();
            this.bottom_vsplit.ResumeLayout(false);
            this.menuAttendance.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip mainToolbar;
        private System.Windows.Forms.SplitContainer main_hsplit;
        private System.Windows.Forms.ListView persons_lv;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader ident;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader age;
        private System.Windows.Forms.ColumnHeader count;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader phone;
        private System.Windows.Forms.ColumnHeader balance;
        private System.Windows.Forms.SplitContainer bottom_vsplit;
        private System.Windows.Forms.ListView aboniments_lv;
        private System.Windows.Forms.ListView attendances_lv;
        private System.Windows.Forms.ColumnHeader abid;
        private System.Windows.Forms.ColumnHeader abstart;
        private System.Windows.Forms.ColumnHeader abend;
        private System.Windows.Forms.ColumnHeader attid;
        private System.Windows.Forms.ColumnHeader attday;
        private System.Windows.Forms.ColumnHeader attattended;
        private System.Windows.Forms.ToolStripButton btnAddPerson;
        private System.Windows.Forms.ToolStripButton btnAddAbonement;
        private System.Windows.Forms.ContextMenuStrip menuAttendance;
        private System.Windows.Forms.ToolStripMenuItem menuItemAttended;

    }
}

