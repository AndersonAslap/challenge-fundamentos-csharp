namespace FundamentosCSharp.src.Projeto02;
static class FullName
{
    public static void Run()
    {
        Console.Write("Digite seu nome: ");
        var name = Console.ReadLine();
        Console.Write("Digite seu sobrenome: ");
        var lastname = Console.ReadLine();

        Console.WriteLine("");
        Console.WriteLine($"Seu nome completo é : {name} {lastname}");
        Console.WriteLine("");
    }
}
