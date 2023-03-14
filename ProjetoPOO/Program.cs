
using ProjetoPOO;

internal class Program
{
    private static void Main(string[] args)
    {
        Person person = new Person("Giovani Ferro", "190", "Caldeirão Furado, 9 3/4");

        Professor professor = new Professor("Professor Papini", "183", "Rua Copacabana, 1000", 1234.56);
        Professor professor2 = new Professor(person, 2345.67);

        Console.WriteLine(person.ToString());
        Console.WriteLine(professor2.ToString());

        Student student = new Student("Sasha", "3356-5666", "Rua Olivio da Barra, 123", 000152);
        student.GradeT1 = 10;
        student.GradeT2 = 3.5;

        Console.WriteLine(student.GetMean(student.GradeT1, student.GradeT2));
        Console.WriteLine(student.GetMean(student.GradeT1, 7, student.GradeT2, 3));
    }
}