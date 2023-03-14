using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOO
{
    internal class Student : Person
    {
        string _name;
        int _studentNumber;
        DateTime _birthDate;


        public void SetName(string name)
        {
            this._name = name;
        }

        public int GetStudentNumber()
        {
            return this._studentNumber;
        }

        public void IsEligibleToEnroll() { }

        public void GetSeminarsTaken() { }
    }
}
