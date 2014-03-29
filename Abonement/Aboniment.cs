using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManagementSystem
{
    public class Aboniment
    {
        public int id;
        public int idPerson;
        public DateTime start;
        public DateTime end;

        public List<Attendance> attendance;

        public Aboniment()
        {
        }
   
        public Aboniment(int id, int idPerson, DateTime start, DateTime end,
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
