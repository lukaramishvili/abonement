using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManagementSystem
{
    public class Person
    {
        public int id;
        public string ident;
        public string name;
        public int age;
        public string address;
        public string phone;
        public decimal balance;
        
        public List<Aboniment> aboniments;

        public Person()
        {
        }

        public Person(int id, string ident, string name, int age, string address,
            string phone, decimal balance, List<Aboniment> aboniments)
        {
            this.id = id; this.ident = ident; this.name = name; this.age = age;
            this.address = address; this.phone = phone; this.balance = balance;
            this.aboniments = aboniments;
        }
    }
}
