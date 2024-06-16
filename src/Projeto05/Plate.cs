using System.Text.RegularExpressions;

namespace FundamentosCSharp.src.Projeto05;

public class Plate
{
    public static void Run()
    {
        Console.Write("Digite a placa do carro: ");
        var plate = Console.ReadLine();

        if (plate == null)
        {
            Console.WriteLine("Falso");
            return;
        }

        bool isValid = Regex.IsMatch(plate, @"^[A-Za-z]{3}\d{4}$");
        
        if (!isValid)
        {
            Console.WriteLine("Falso");
        }
        else
        {
            Console.WriteLine("Verdadeiro");
        }
    }
}
