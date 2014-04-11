using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManagementSystem
{
    [Serializable]
    public class Abonement
    {
        public int id = 0;
        public int idPerson = 0;
        public DateTime start = DateTime.Now;
        public DateTime end = DateTime.Now;

        //public decimal price = 0.0m;

        public bool mon = false;
        public int monHour = 0;
        public bool tue = false;
        public int tueHour = 0;
        public bool wed = false;
        public int wedHour = 0;
        public bool thu = false;
        public int thuHour = 0;
        public bool fri = false;
        public int friHour = 0;
        public bool sat = false;
        public int satHour = 0;
        public bool sun = false;
        public int sunHour = 0;

        public List<Attendance> attendance = new List<Attendance>();

        public Abonement()
        {
        }
   
        public Abonement(int id, int idPerson, DateTime start, DateTime end,
                List<Attendance> attendance)
        {
            this.id = id;
            this.idPerson = idPerson;
            this.start = start;
            this.end = end;
            this.attendance = attendance;
        }
    }
}
