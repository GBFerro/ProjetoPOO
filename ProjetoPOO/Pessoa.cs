using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOO
{
    internal class Pessoa
    {

        string _name;
        string _lastName;

        public Pessoa() { }

        public int Idade { get; set; }



        public void SetName(string name)
        {
            this._name = name;
        }

        public string GetName()
        {
            return this._name;
        }

        public void SetLastName(string name)
        {
            this._lastName = name;
        }

        public string GetLastName()
        {
            return this._lastName;
        }

        public string GetCompleteName()
        {
            return this._name + " " + this._lastName;
        }



    }
}

