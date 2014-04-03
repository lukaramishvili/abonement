using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace ManagementSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public static ListViewItem lviForInstance(Object o, ListView lv)
        {
            List<string> items = new List<string>();
            foreach (ColumnHeader ch in lv.Columns)
            {
                /*ch.Name doesn't work (a bug), so Tag is used for column name*/
                System.Reflection.FieldInfo fi = o.GetType().GetField(ch.Tag.ToString());
                if (fi != null)
                {
                    items.Add(fi.GetValue(o).ToString());
                }
            }
            ListViewItem lvi = new ListViewItem(items.ToArray());
            return lvi;
        }

        public static string getColumnValue(ListViewItem lvi, string tag)
        {
            string ret = "";
            foreach (ColumnHeader ch in lvi.ListView.Columns)
            {
                if (tag == ch.Tag.ToString())
                {
                    ret = lvi.SubItems[ch.Index].Text;
                }
            }
            return ret;
        }

        public void displayPersons(List<Person> persons)
        {
            attendances_lv.Items.Clear();
            abonements_lv.Items.Clear();
            persons_lv.Items.Clear();
            for (int ip = 0; ip < persons.Count; ip++)
            {
                Person p = persons[ip];
                persons_lv.Items.Add(lviForInstance(p, persons_lv));
            }
        }

        public void displayAbonements(List<Abonement> abonements)
        {
            attendances_lv.Items.Clear();
            abonements_lv.Items.Clear();
            for (int iab = 0; iab < abonements.Count; iab++)
            {
                Abonement ab = abonements[iab];
                abonements_lv.Items.Add(lviForInstance(ab, abonements_lv));
            }
        }

        public void displayAttendances(List<Attendance> attendances)
        {
            attendances_lv.Items.Clear();
            for (int iatt = 0; iatt < attendances.Count; iatt++)
            {
                Attendance att = attendances[iatt];
                attendances_lv.Items.Add(lviForInstance(att, attendances_lv));
            }
        }

        private int getSelectedPersonId()
        {
            int ret = -1;
            if (persons_lv.SelectedItems.Count > 0)
            {
                ret = Int32.Parse(getColumnValue(persons_lv.SelectedItems[0], "id"));
            }
            return ret;
        }

        private int getSelectedAbonementId()
        {
            int ret = -1;
            if (abonements_lv.SelectedItems.Count > 0)
            {
                ret = Int32.Parse(getColumnValue(abonements_lv.SelectedItems[0], "id"));
            }
            return ret;
        }

        private int getSelectedAttendanceId()
        {
            int ret = -1;
            if (attendances_lv.SelectedItems.Count > 0)
            {
                ret = Int32.Parse(getColumnValue(attendances_lv.SelectedItems[0], "id"));
            }
            return ret;
        }

        private int getNextPersonId()
        {
            var queryMax = (from p in data select p.id);
            int maxId = queryMax.Count() > 0 ? queryMax.Max() : 0;
            int nextId = -1;
            //the id should increment until reaching 777, then fill the freed holes from deleted persons ids
            if (maxId >= 777) {
                for (int i = 1; i <= 777; i++)
                {
                    if ((from p in data where p.id == i select p).Count() == 0)
                    {
                        nextId = i;
                        break;
                    }
                }
            }
            else { nextId = maxId + 1; }
            return nextId;
        }

        private int getNextAbonementId()
        {
            int maxId = 1;
            foreach (Person p in data)
            {
                foreach (Abonement ab in p.abonements)
                {
                    maxId = Math.Max(maxId, ab.id);
                }
            }
            return maxId + 1;
        }

        private int getNextAttendanceId()
        {
            int maxId = 1;
            foreach (Person p in data)
            {
                foreach (Abonement ab in p.abonements)
                {
                    foreach (Attendance att in ab.attendance)
                    {
                        maxId = Math.Max(maxId, att.id);
                    }
                }
            }
            return maxId + 1;
        }

        private Person getPersonById(int id)
        {
            Person ret = null;
            foreach (Person p in data)
            {
                if (p.id == id) { ret = p; }
            }
            return ret;
        }

        private Abonement getAbonementById(int id)
        {
            Abonement ret = null;
            foreach (Person p in data)
            {
                foreach (Abonement ab in p.abonements)
                {
                    if (ab.id == id) { ret = ab; }
                }
            }
            return ret;
        }

        private Attendance getAttendanceById(int id)
        {
            Attendance ret = null;
            foreach (Person p in data)
            {
                foreach (Abonement ab in p.abonements)
                {
                    foreach (Attendance att in ab.attendance)
                    {
                        if (att.id == id) { ret = att; }
                    }
                }
            }
            return ret;
        }

        private int getPersonIndexById(int id)
        {
            int ret = -1;
            for(int ip = 0; ip < data.Count; ip++)
            {
                Person p = data[ip];
                if (p.id == id) { ret = ip; }
            }
            return ret;
        }

        private Tuple<int, int> getAbonementIndexById(int id)
        {
            int retPersonIndex = -1;
            int retAbonementIndex = -1;
            for (int ip = 0; ip < data.Count; ip++)
            {
                Person p = data[ip];
                for (int iab = 0; iab < p.abonements.Count; iab++)
                {
                    Abonement ab = p.abonements[iab];
                    if (ab.id == id)
                    {
                        retPersonIndex = ip;
                        retAbonementIndex = iab;
                    }
                }
            }
            return new Tuple<int,int>(retPersonIndex, retAbonementIndex);
        }

        private Tuple<int,int,int> getAttendanceIndexById(int id)
        {
            int retPersonIndex = -1;
            int retAbonementIndex = -1;
            int retAttendanceIndex = -1;
            for (int ip = 0; ip < data.Count; ip++)
            {
                Person p = data[ip];
                for (int iab = 0; iab < p.abonements.Count; iab++)
                {
                    Abonement ab = p.abonements[iab];
                    for (int iatt = 0; iatt < ab.attendance.Count; iatt++)
                    {
                        Attendance att = ab.attendance[iatt];
                        if (att.id == id)
                        {
                            retPersonIndex = ip;
                            retAbonementIndex = iab;
                            retAttendanceIndex = iatt;
                        }
                    }
                }
            }
            return new Tuple<int, int, int>(retPersonIndex, retAbonementIndex, retAttendanceIndex);
        }

        //displays edit form for a class instance. the class should have a parameterless constructor or it won't work
        /* example use:
                displayEditForm(new Person(), delegate(Object o) {
                    Person p = (Person)o;
                    MessageBox.Show(p.name);
                });
         */
        private void displayEditForm(Object o, Action<object> callback)
        {
            Form editForm = new Form();
            bool fSaved = false;//don't ask for close confirmation when this flag is set (by btnSave.Click)
            int xPos = 10;
            int yPos = 0;
            //which field name (stored label.Tag) is associated with which control
            Dictionary<string, Control> assoc = new Dictionary<string,Control>();
            foreach (System.Reflection.FieldInfo fi in o.GetType().GetFields())
            {
                int yInc = 30;//how much vertical space does the current editor take
                Label lblDef = new Label();
                lblDef.Text = fi.Name;
                lblDef.Left = xPos;
                //field name is saved in label's Tag attribute
                lblDef.Tag = fi.Name;
                //first, decide which editor to use based on the field name
                switch (fi.Name)
                {
                    case "id":
                    case "idPerson":
                    case "idAbonement":
                        yInc = 0;//these controls are hidden, so don't reserve any vertical space for them
                        NumericUpDown numId = new NumericUpDown();
                        numId.DecimalPlaces = 0;
                        numId.Value = (int)fi.GetValue(o);
                        lblDef.Top = numId.Top = yPos;
                        numId.Left = xPos + lblDef.Width + 10;
                        assoc[fi.Name] = numId;
                        //hide id controls, it shouldn't be editable; it's here to let the callback know which item we're updating
                        numId.Visible = false;
                        lblDef.Visible = false;
                        editForm.Controls.Add(lblDef);
                        editForm.Controls.Add(numId);
                        break;
                    //if the fieldname-specific editor isn't set, then choose an editor based on the field type
                    default:
                        switch (fi.FieldType.ToString())
                        {
                            case "System.Boolean":
                                CheckBox boolEd = new CheckBox();
                                boolEd.Checked = (bool)fi.GetValue(o);
                                lblDef.Top = boolEd.Top = yPos;
                                boolEd.Left = xPos + lblDef.Width + 10;
                                assoc[fi.Name] = boolEd;
                                //don't allow a moderator to change attended status
                                if (fi.Name == "attended" && loginStatus != "administrator")
                                {
                                    boolEd.Enabled = false;
                                }
                                editForm.Controls.Add(lblDef);
                                editForm.Controls.Add(boolEd);
                                break;
                            case "System.Int32":
                                NumericUpDown numEd = new NumericUpDown();
                                numEd.DecimalPlaces = 0;
                                numEd.Value = (int)fi.GetValue(o);
                                lblDef.Top = numEd.Top = yPos;
                                numEd.Left = xPos + lblDef.Width + 10;
                                assoc[fi.Name] = numEd;
                                editForm.Controls.Add(lblDef);
                                editForm.Controls.Add(numEd);
                                break;
                            case "System.Decimal":
                                NumericUpDown decEd = new NumericUpDown();
                                decEd.DecimalPlaces = 2;
                                decEd.Value = (decimal)fi.GetValue(o);
                                lblDef.Top = decEd.Top = yPos;
                                decEd.Left = xPos + lblDef.Width + 10;
                                assoc[fi.Name] = decEd;
                                editForm.Controls.Add(lblDef);
                                editForm.Controls.Add(decEd);
                                break;
                            case "System.DateTime":
                                DateTimePicker dateEd = new DateTimePicker();
                                dateEd.Value = (DateTime)fi.GetValue(o);
                                lblDef.Top = dateEd.Top = yPos;
                                dateEd.Left = xPos + lblDef.Width + 10;
                                assoc[fi.Name] = dateEd;
                                editForm.Controls.Add(lblDef);
                                editForm.Controls.Add(dateEd);
                                break;
                            case "System.String":
                                TextBox tbDef = new TextBox();
                                tbDef.Text = fi.GetValue(o).ToString();
                                lblDef.Top = tbDef.Top = yPos;
                                tbDef.Left = xPos + lblDef.Width + 10;
                                assoc[fi.Name] = tbDef;
                                editForm.Controls.Add(lblDef);
                                editForm.Controls.Add(tbDef);
                                break;
                            //there is no default field editor, we're only editing primitive types for now
                            default:
                                break;
                        }
                        break;
                }
                yPos += yInc;
            }
            Button btnSave = new Button();
            btnSave.Width = 120;
            btnSave.Left = xPos;
            btnSave.Top = yPos;
            btnSave.Text = "დამახსოვრება";
            editForm.Controls.Add(btnSave);
            editForm.AcceptButton = btnSave;
            btnSave.Click += new EventHandler(delegate
            {
                //reuse the passed parameter which we're editing; this is necessary to retain any noneditable fields/members
                object edited = o;// Activator.CreateInstance(o.GetType());
                foreach (Control ctrl in editForm.Controls)
                {
                    if (ctrl.GetType() == typeof(Label) && ctrl.Tag != null)
                    {
                        System.Reflection.FieldInfo fi = o.GetType().GetField(ctrl.Tag.ToString());
                        if (fi != null)
                        {
                            switch (fi.FieldType.ToString())
                            {
                                case "System.Boolean":
                                    fi.SetValue(edited, ((CheckBox)assoc[ctrl.Tag.ToString()]).Checked);
                                    break;
                                case "System.Int32":
                                    fi.SetValue(edited, (int)((NumericUpDown)assoc[ctrl.Tag.ToString()]).Value);
                                    break;
                                case "System.Decimal":
                                    fi.SetValue(edited, (decimal)((NumericUpDown)assoc[ctrl.Tag.ToString()]).Value);
                                    break;
                                case "System.DateTime":
                                    fi.SetValue(edited, (DateTime)((DateTimePicker)assoc[ctrl.Tag.ToString()]).Value);
                                    break;
                                case "System.String":
                                    fi.SetValue(edited, assoc[ctrl.Tag.ToString()].Text);
                                    break;
                                default:
                                    MessageBox.Show(fi.Name + " value hasn't been updated");
                                    break;
                            }
                        }
                    }
                }
                callback(edited);
                fSaved = true;
                editForm.Close();
            });
            editForm.FormClosing += new FormClosingEventHandler(delegate (object sender, FormClosingEventArgs e)
            {
                //don't ask for close confirmation when closing occured by clicking the save button
                if (!fSaved
                    && MessageBox.Show("გავაუქმოთ ჩასწორება?", "დადასტურება", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.No)
                {
                    e.Cancel = true;
                }
            });
            editForm.ShowDialog();
        }

        public static List<Person> data = new List<Person>();
        public string loginStatus = "none";

        private void Main_Load(object sender, EventArgs e)
        {
            Form frmLogin = new Form(); frmLogin.Text = "შესვლა";
            Label lblUsername = new Label(); lblUsername.Text = "მომხმარებელი"; lblUsername.Left = 10; lblUsername.Top = 10;
            TextBox txtUsername = new TextBox(); txtUsername.Left = 10; txtUsername.Top = 40;
            Label lblPassword = new Label(); lblPassword.Text = "პაროლი"; lblPassword.Left = 10; lblPassword.Top = 70;
            TextBox txtPassword = new TextBox(); txtPassword.PasswordChar = '*'; txtPassword.Left = 10; txtPassword.Top = 100;
            Button btnLogin = new Button(); btnLogin.Text = "შესვლა"; btnLogin.Left = 10; btnLogin.Top = 130;
            frmLogin.Controls.AddRange(new Control[] { lblUsername, txtUsername, lblPassword, txtPassword, btnLogin });
            frmLogin.AcceptButton = btnLogin;
            bool fClickedDontTryAgain = false;//otherwise, FormClosing gets called twice
            btnLogin.Click += new EventHandler(delegate
            {
                if (txtUsername.Text == "admin" && txtPassword.Text == "123") { loginStatus = "administrator"; }
                else if (txtUsername.Text == "moderator" && txtPassword.Text == "123") { loginStatus = "moderator"; }
                else { MessageBox.Show("მომხმარებლის სახელი ან პაროლი არასწორია"); }
                if (loginStatus != "none") {
                    labelLoginStatus.Text = "თქვენ შემოსული ხართ, როგორც " + loginStatus;
                    fClickedDontTryAgain = true; frmLogin.Close();
                }
            });
            frmLogin.FormClosing += new FormClosingEventHandler(delegate (object senderLogin, FormClosingEventArgs eLogin)
            {
                if (!fClickedDontTryAgain)
                {
                    if (DialogResult.Yes == MessageBox.Show("გსურთ პროგრამიდან გამოსვლა?", "დადასტურება", MessageBoxButtons.YesNo))
                    {
                        fClickedDontTryAgain = true;
                        Application.Exit();
                    }
                    else { eLogin.Cancel = true; }
                }
            });
            frmLogin.ShowDialog();

            if (LoadData())
            {
                //make backup of previous data with save data, and start with fresh
                SaveData();
                this.displayPersons(data);//moved to here instead of after if
            }
            else
            {
                /*
                //test data
                data.Add(new Person(1, "0101", "სატესტო", 32, "ინფორმაცია", "599", 15.0m,
                    new[] {
                    new Abonement(1, 9, DateTime.Now, DateTime.Now,
                                new [] {
                                    new Attendance(0, 0, 0, DateTime.Now, true)
                                }.ToList<Attendance>()) 
                }.ToList<Abonement>()
                                    ));
                //iadab, idatt: autoincrement-like mechanism for other classes (no abonement should have the same id)
                //indexes != id-s !!!
                for (int ip = 0, idab = 0, idatt = 0; ip < data.Count; ip++)
                {
                    Person p = data[ip];
                    for (int iab = 0; iab < p.abonements.Count; iab++)
                    {
                        Abonement ab = p.abonements[iab];
                        ab.id = idab++;
                        ab.idPerson = p.id;
                        for (int iatt = 0; iatt < ab.attendance.Count; iatt++)
                        {
                            Attendance att = ab.attendance[iatt];
                            att.id = idatt++;
                            att.idPerson = p.id;
                            att.idAbonement = iab;
                        }
                    }
                }
                 */
            }
        }

        private void persons_lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (persons_lv.SelectedItems.Count > 0)
            {
                //display abonements when a person is selected
                Person p = data[getPersonIndexById(this.getSelectedPersonId())];
                if (p.abonements != null)
                {
                    displayAbonements(p.abonements);
                }
            }
            else { displayAbonements(new List<Abonement>()); }
        }

        private void abonements_lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (abonements_lv.SelectedItems.Count > 0)
            {
                btnAddAttendance.Enabled = true;
                //display attendances when an abonement is selected
                int id = getSelectedAbonementId();
                int idPerson = Int32.Parse(getColumnValue(persons_lv.SelectedItems[0], "id"));
                int indexPerson = getPersonIndexById(idPerson);
                Abonement[] ab = (from fab in data[indexPerson].abonements
                                  where fab.id == id
                                  select fab).ToArray();
                //if the list is empty, then call displayAttendances anyway to clear the displayed list
                displayAttendances(ab[0].attendance);
            }
            else { btnAddAttendance.Enabled = false; }
        }

        private void menuItemAttended_Click(object sender, EventArgs e)
        {
            if (attendances_lv.SelectedItems.Count > 0)
            {
                
            }
        }

        private void attendances_lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (attendances_lv.SelectedItems.Count > 0)
            {
                int id = getSelectedAttendanceId();
                //TODO:what?
            }
        }

        private void persons_lv_DoubleClick(object sender, EventArgs e)
        {
            int id = getSelectedPersonId();
            if (id > -1)
            {
                int indexPerson = getPersonIndexById(id);
                displayEditForm(data[indexPerson], delegate(Object o)
                {
                    Person p = (Person)o;
                    //update the value in "database"
                    data[indexPerson] = p;
                    displayPersons(data);
                });
            }
        }

        private void abonements_lv_DoubleClick(object sender, EventArgs e)
        {
            int id = getSelectedAbonementId();
            if (id > -1)
            {
                Abonement abToEdit = getAbonementById(id);
                if (abToEdit != null)
                {
                    displayEditForm(abToEdit, delegate(Object o)
                    {
                        Abonement ab = (Abonement)o;
                        //update the value in database
                        Tuple<int,int> path = getAbonementIndexById(ab.id);
                        if (path.Item1 != -1 && path.Item2 != -1)
                        {
                            data[path.Item1].abonements[path.Item2] = ab;
                        }
                        displayAbonements(getPersonById(ab.idPerson).abonements);
                    });
                }
            }
        }

        private void attendances_lv_DoubleClick(object sender, EventArgs e)
        {
            int id = getSelectedAttendanceId();
            if (id > -1)
            {
                Attendance attToEdit = getAttendanceById(id);
                if (attToEdit != null)
                {
                    displayEditForm(attToEdit, delegate(Object o)
                    {
                        Attendance att = (Attendance)o;
                        //update the value in database
                        Tuple<int, int, int> path = getAttendanceIndexById(att.id);
                        if (path.Item1 != -1 && path.Item2 != -1 && path.Item3 != -1)
                        {
                            data[path.Item1].abonements[path.Item2].attendance[path.Item3] = att;
                        }
                        displayAttendances(getAbonementById(att.idAbonement).attendance);
                    });
                }
            }
        }

        private void btnShowAllPersons_Click(object sender, EventArgs e)
        {
            displayPersons(data);
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            clearSearchFields();
            displayPersons(data);
        }

        private void DoTextSearch()
        {
            System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(txtSearch.Text);
            var filtered = (from p in data
                               where reg.IsMatch(p.name) || reg.IsMatch(p.address) || reg.IsMatch(p.phone)
                               select p).ToList<Person>();
            displayPersons(filtered);
        }

        private void clearSearchFields()
        {
            //clear search fields
            txtSearch.Text = "";
            //other filters are date/time pickers, so there's no sense clearing them
        }

        private void btnAddAbonement_Click(object sender, EventArgs e)
        {
            if (persons_lv.SelectedIndices.Count > 0)
            {
                int idPerson = getSelectedPersonId();
                int indexPerson = getPersonIndexById(idPerson);
                Abonement abToEdit = new Abonement();
                abToEdit.idPerson = idPerson;
                //this code runs only when adding an abonement
                displayEditForm(abToEdit, delegate(object o)
                {
                    Abonement ab = (Abonement)o;
                    ab.id = getNextAbonementId();
                    data[indexPerson].abonements.Add(ab);
                    displayAbonements(data[indexPerson].abonements);
                });
            }
            else { MessageBox.Show("გთხოვთ მონიშნოთ პიროვნება."); }
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Person pToEdit = new Person();
            //this code runs only when adding a person
            displayEditForm(pToEdit, delegate(object o)
            {
                Person p = (Person)o;
                p.id = getNextPersonId();
                if (p.id == -1) { MessageBox.Show("პიროვნება ვერ დაემატება, მიღწეულია 777 ლიმიტი."); return; }
                data.Add(p);
                displayPersons(data);
            });
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!SaveData())
            {
                if (DialogResult.Yes == MessageBox.Show("მონაცემების დამახსოვრება ვერ მოხერხდა! მაინც გსურთ გამოსვლა?", "შეცდომა",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error))
                {
                    e.Cancel = true;
                }
            }
        }

        private string getHomePath()
        {
            return (Environment.OSVersion.Platform == PlatformID.Unix ||
                Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
        }

        /// <summary>
        /// Saves data to ~/Abonement
        /// </summary>
        /// <returns>Success flag</returns>
        private bool SaveData()
        {
            string homeDir = getHomePath();
            string saveDir = homeDir + "/Abonement";
            string backupsDir = saveDir + "/backups";
            string saveFile = saveDir + "/data.dat";
            if (!Directory.Exists(saveDir)) { Directory.CreateDirectory(saveDir); }
            if (!Directory.Exists(backupsDir)) { Directory.CreateDirectory(backupsDir); }
            //backup ~/Abonement/data.dat in ~/Abonement/backups/data00MAX+1.bak
            int nextBakId = 0;
            while (0 < ++nextBakId && File.Exists(backupsDir + "/data" + nextBakId.ToString("D3") + ".bak")) ;
            if (File.Exists(saveFile)) { File.Copy(saveFile, backupsDir + "/data" + nextBakId.ToString("D3") + ".bak"); }
            //serialize "data" variable and save
            System.Runtime.Serialization.IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            Stream stream = new FileStream(saveFile, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, ManagementSystem.Main.data);
            stream.Close();
            return true;
        }

        private bool LoadData()
        {
            //load data from ~/Abonement/data.dat
            string homeDir = getHomePath();
            string saveDir = homeDir + "/Abonement";
            string backupsDir = saveDir + "/backups";
            string saveFile = saveDir + "/data.dat";
            if (File.Exists(saveFile))
            {
                System.Runtime.Serialization.IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                Stream stream = new FileStream(saveFile, FileMode.Open, FileAccess.Read, FileShare.Read);
                ManagementSystem.Main.data = (List<Person>)formatter.Deserialize(stream);
                stream.Close();
                return true;
            }
            else { return false; }
        }

        private void btnSaveAllData_Click(object sender, EventArgs e)
        {
            if (!SaveData())
            {
                MessageBox.Show("მონაცემების დამახსოვრება ვერ მოხერხდა");
            }
        }

        private void btnAddAttendance_Click(object sender, EventArgs e)
        {
            if (persons_lv.SelectedIndices.Count > 0)
            {
                int idPerson = getSelectedPersonId();
                int indexPerson = getPersonIndexById(idPerson);
                if (abonements_lv.SelectedIndices.Count > 0)
                {
                    int idAbonement = getSelectedAbonementId();
                    int indexAbonement = getPersonIndexById(idPerson);
                    Attendance attToEdit = new Attendance();
                    attToEdit.idPerson = idPerson;
                    attToEdit.idAbonement = idAbonement;
                    //this code runs only when adding an abonement
                    displayEditForm(attToEdit, delegate(object o)
                    {
                        Attendance att = (Attendance)o;
                        att.id = getNextAttendanceId();
                        data[indexPerson].abonements[indexAbonement].attendance.Add(att);
                        displayAttendances(data[indexPerson].abonements[indexAbonement].attendance);
                    });
                }
                else { /*it can't reach here, on abonement deselect this btn gets disabled*/ }
            }
            else { MessageBox.Show("გთხოვთ მონიშნოთ პიროვნება."); }
        }

        private void btnTextSearch_Click(object sender, EventArgs e)
        {
            DoTextSearch();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void btnTodayStats_Click(object sender, EventArgs e)
        {
            var hour = stat_today_hour.Value.Hour;
            var filtered = (from p in data
                            where (from ab in p.abonements
                                   where (from att in ab.attendance
                                              where att.time == hour
                                              select att).Count() > 0
                                   select ab).Count() > 0
                            select p).ToList<Person>();
            displayPersons(filtered);
        }


        //
    }
}
