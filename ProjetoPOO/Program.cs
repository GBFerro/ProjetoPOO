
using ProjetoPOO;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa person = new Pessoa();
        Pessoa person2 = new Pessoa();

        Console.WriteLine("Informe seu nome: ");
        person.SetName(Console.ReadLine());

        Console.WriteLine("Informe seu sobrenome: ");
        person.SetLastName(Console.ReadLine());

        Console.WriteLine("Informe sua idade: ");
        person.Idade = int.Parse(Console.ReadLine());

        Console.WriteLine($"Seja bem vindo a OO, {person.GetName()}");


        Console.WriteLine($"Você tem {person.Idade} anos");

        Console.WriteLine($"Seu nome completo é: {person.GetCompleteName()}");
    }
}