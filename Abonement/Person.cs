using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManagementSystem
{
    [Serializable]
    public class Person
    {
        public int id = 0;
        public string ident = "";
        public string name = "";
        public int age = 0;
        public string address = "";
        public string phone = "";
        public string balance = "";//0.0m;
        
        public List<Abonement> abonements = new List<Abonement>();

        public Person()
        {
        }

        public Person(int id, string ident, string name, int age, string address,
            string phone, string balance, List<Abonement> abonements)
        {
            this.id = id; this.ident = ident; this.name = name; this.age = age;
            this.address = address; this.phone = phone; this.balance = balance;
            this.abonements = abonements;
        }
    }
}
