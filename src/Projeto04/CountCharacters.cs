namespace FundamentosCSharp.src.Projeto04;

public class CountCharacters
{
    public static void Run()
    {
        Console.Write("Digite uma ou mais palavras: ");
        string input = Console.ReadLine();

        int characterCount = 0;

        if (!string.IsNullOrEmpty(input)) {
            var words = input.Split(" ");

            foreach (var word in words)
            {
                characterCount += word.Length;
            }

        }

        Console.WriteLine($"Total de caracteres (sem espaços): {characterCount}");
    }
}
