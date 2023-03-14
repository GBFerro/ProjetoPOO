using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOO
{
    internal class Student : Person
    {
        public int Enrolment { get; set; }
        public double GradeT1 { get; set; }
        public double GradeT2 { get; set; }

        public Student(string name, string phone, string address, int enrolment) : base(name, phone, address)
        {
            this.Enrolment = enrolment;
        }

        public override string ToString()
        {
            return base.ToString() + " - " + this.Enrolment;
        }

        public string GetMean(double grade1, double grade2)
        {

            return $"A média do aluno {this.Name} é: {(grade1 + grade2) / 2}";
        }

        public string GetMean(double grade1, double weighted1, double grade2, double weighted2)
        {
            return $"A média do aluno {this.Name} é: {((grade1 * weighted1) + (grade2 * weighted2)) / (weighted1 + weighted2)}";
        }
    }
}
