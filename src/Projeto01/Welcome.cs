namespace FundamentosCSharp.src.Project01;

public class Welcome
{
    public static void Run()
    {
        Console.Write("Digite seu nome: ");
        var name = Console.ReadLine();

        Console.WriteLine("");
        Console.WriteLine($"Olá, {name}! Seja muito bem-vindo!");
        Console.WriteLine("");
    }
}
