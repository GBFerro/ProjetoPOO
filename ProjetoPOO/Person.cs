using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOO
{
    internal class Person
    {
        public string Name { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public Person(string name, string phone, string address)
        {
            this.Name = name;
            this.Phone = phone;
            this.Address = address;
        }


        public override string ToString()
        {
            return (this.Name +" - "+ this.Phone + " - " + this.Address);
        }
    }
}

