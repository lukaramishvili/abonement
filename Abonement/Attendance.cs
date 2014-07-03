using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManagementSystem
{
    [Serializable]
    public class Attendance
    {
        public int id = 0;
        public int idPerson = 0;
        public int idAbonement = 0;
        //hour component of when attendance took place is stored in this variable's Hour variable
        public DateTime day = DateTime.Now;
        public int time
        {
            get { return day.Hour; }
            set { day.AddHours(value); }
        }
        public int attended = 2;

        public Attendance()
        {
        }

        public Attendance(int id, int idPerson, int idAbonement, DateTime day, int time, int attended)
        {
            this.id = id; this.idPerson = idPerson; this.idAbonement = idAbonement;
            this.day = day; day.AddHours(time); this.attended = attended;
        }
    }
}
