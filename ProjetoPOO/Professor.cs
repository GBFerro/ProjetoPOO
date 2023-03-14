using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOO
{
    internal class Professor : Person
    {
        public double Salary { get; set; }

        public Professor(string name, string phone, string address, double salary) : base(name, phone, address)

        {

            this.Salary = salary;
        }

        public Professor(Person person, double salary) : base(person.Name, person.Phone, person.Address)
        { 
            this.Salary = salary; 
        }

        public override string ToString()
        {
            return base.ToString() + " - " + this.Salary;
        }
    }
}
