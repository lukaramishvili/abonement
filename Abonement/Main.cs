using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

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
            var ret = "";
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
            aboniments_lv.Items.Clear();
            persons_lv.Items.Clear();
            for (int ip = 0; ip < persons.Count; ip++)
            {
                Person p = persons[ip];
                persons_lv.Items.Add(lviForInstance(p, persons_lv));
            }
        }

        public void displayAboniments(List<Aboniment> aboniments)
        {
            attendances_lv.Items.Clear();
            aboniments_lv.Items.Clear();
            for (int iab = 0; iab < aboniments.Count; iab++)
            {
                Aboniment ab = aboniments[iab];
                aboniments_lv.Items.Add(lviForInstance(ab, aboniments_lv));
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
            var ret = -1;
            if (persons_lv.SelectedItems.Count > 0)
            {
                ret = Int32.Parse(getColumnValue(persons_lv.SelectedItems[0], "id"));
            }
            return ret;
        }

        private int getSelectedAbonementId()
        {
            var ret = -1;
            if (aboniments_lv.SelectedItems.Count > 0)
            {
                ret = Int32.Parse(getColumnValue(aboniments_lv.SelectedItems[0], "id"));
            }
            return ret;
        }

        private int getSelectedAttendanceId()
        {
            var ret = -1;
            if (attendances_lv.SelectedItems.Count > 0)
            {
                ret = Int32.Parse(getColumnValue(attendances_lv.SelectedItems[0], "id"));
            }
            return ret;
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

        private Aboniment getAbonimentById(int id)
        {
            Aboniment ret = null;
            foreach (Person p in data)
            {
                foreach (Aboniment ab in p.aboniments)
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
                foreach (Aboniment ab in p.aboniments)
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

        private Tuple<int, int> getAbonimentIndexById(int id)
        {
            int retPersonIndex = -1;
            int retAbonimentIndex = -1;
            for (int ip = 0; ip < data.Count; ip++)
            {
                Person p = data[ip];
                for (int iab = 0; iab < p.aboniments.Count; iab++)
                {
                    Aboniment ab = p.aboniments[iab];
                    if (ab.id == id)
                    {
                        retPersonIndex = ip;
                        retAbonimentIndex = iab;
                    }
                }
            }
            return new Tuple<int,int>(retPersonIndex, retAbonimentIndex);
        }

        private Tuple<int,int,int> getAttendanceIndexById(int id)
        {
            int retPersonIndex = -1;
            int retAbonimentIndex = -1;
            int retAttendanceIndex = -1;
            for (int ip = 0; ip < data.Count; ip++)
            {
                Person p = data[ip];
                for (int iab = 0; iab < p.aboniments.Count; iab++)
                {
                    Aboniment ab = p.aboniments[iab];
                    for (int iatt = 0; iatt < ab.attendance.Count; iatt++)
                    {
                        Attendance att = ab.attendance[iatt];
                        if (att.id == id)
                        {
                            retPersonIndex = ip;
                            retAbonimentIndex = iab;
                            retAttendanceIndex = iatt;
                        }
                    }
                }
            }
            return new Tuple<int, int, int>(retPersonIndex, retAbonimentIndex, retAttendanceIndex);
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
                    case "idAboniment":
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
            btnSave.Left = xPos;
            btnSave.Top = yPos;
            btnSave.Text = "დამახსოვრება";
            editForm.Controls.Add(btnSave);
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

        private void Main_Load(object sender, EventArgs e)
        {
            //TODO: real data
            data.Add(new Person(0, "0101", "Luka", 23, "Shanidze", "577", 15.0m,
                new [] {
                    new Aboniment(0, 9, DateTime.Now, DateTime.Now,
                                new [] {
                                    new Attendance(0, 0, 0, DateTime.Now, true)
                                }.ToList<Attendance>()) 
                }.ToList<Aboniment>()
                                ));
            //iadab, idatt: autoincrement-like mechanism for other classes (no aboniment should have the same id)
            //so, actually, for now person.id == its index in 'data array, but aboniments and attendances ids differ from their indexes
            for (int ip = 0, idab = 0, idatt = 0; ip < data.Count; ip++)
            {
                Person p = data[ip];
                /*use array indexes as id-s and set the id fields accordingly*/
                p.id = ip;
                for (int iab = 0; iab < p.aboniments.Count; iab++)
                {
                    Aboniment ab = p.aboniments[iab];
                    ab.id = idab++;
                    ab.idPerson = p.id;
                    for (int iatt = 0; iatt < ab.attendance.Count; iatt++)
                    {
                        Attendance att = ab.attendance[iatt];
                        att.id = idatt++;
                        att.idPerson = p.id;
                        att.idAboniment = iab;
                    }
                }
            }
            this.displayPersons(data);
        }

        private void persons_lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (persons_lv.SelectedItems.Count > 0)
            {
                //display aboniments when a person is selected
                Person p = data[this.getSelectedPersonId()];
                if (p.aboniments != null)
                {
                    displayAboniments(p.aboniments);
                }
            }
        }

        private void aboniments_lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (aboniments_lv.SelectedItems.Count > 0)
            {
                //display attendances when an aboniment is selected
                int id = getSelectedAbonementId();
                Aboniment[] ab = (from fab in data[Int32.Parse(getColumnValue(persons_lv.SelectedItems[0], "id"))].aboniments
                               where fab.id == id
                               select fab).ToArray();
                //TODO: is the length check necessary? if the list is empty, then call displayAttendances to clear the displayed list
                if (true || ab.Length > 0) { displayAttendances(ab[0].attendance); }
            }
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
            }
        }

        private void persons_lv_DoubleClick(object sender, EventArgs e)
        {
            int id = getSelectedPersonId();
            if (id > -1)
            {
                displayEditForm(data[id], delegate(Object o) {
                    Person p = (Person)o;
                    //update the value in "database"
                    data[id] = p;
                    displayPersons(data);
                });
            }
        }

        private void aboniments_lv_DoubleClick(object sender, EventArgs e)
        {
            int id = getSelectedAbonementId();
            if (id > -1)
            {
                Aboniment abToEdit = getAbonimentById(id);
                if (abToEdit != null)
                {
                    displayEditForm(abToEdit, delegate(Object o)
                    {
                        Aboniment ab = (Aboniment)o;
                        //update the value in database
                        Tuple<int,int> path = getAbonimentIndexById(ab.id);
                        if (path.Item1 != -1 && path.Item2 != -1)
                        {
                            data[path.Item1].aboniments[path.Item2] = ab;
                        }
                        displayAboniments(getPersonById(ab.idPerson).aboniments);
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
                            data[path.Item1].aboniments[path.Item2].attendance[path.Item3] = att;
                        }
                        displayAttendances(getAbonimentById(att.idAboniment).attendance);
                    });
                }
            }
        }


        //
    }
}
