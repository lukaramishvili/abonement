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
