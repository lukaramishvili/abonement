using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManagementSystem
{
    public class Attendance
    {
        public int id;
        public int idPerson;
        public int idAboniment;
        public DateTime day;
        public bool attended;

        public Attendance()
        {
        }

        public Attendance(int id, int idPerson, int idAboniment, DateTime day, bool attended)
        {
            this.id = id; this.idPerson = idPerson; this.idAboniment = idAboniment;
            this.day = day; this.attended = attended;
        }
    }
}
