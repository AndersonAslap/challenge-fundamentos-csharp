namespace FundamentosCSharp.src.Projeto06;

public class Datetimer
{
    public static void Run()
    {
        DateTime now = DateTime.Now;

        Console.Write("Exibição das datas em diferentes formatos: ");
        Console.WriteLine("");
        Console.WriteLine("");

        Console.Write("Formato completo: ");
        Console.WriteLine(now.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
        Console.WriteLine("");

        Console.Write("Apenas a data: ");
        Console.WriteLine(now.ToString("dd/MM/yyyy"));
        Console.WriteLine("");

        Console.Write("Apenas a hora: ");
        Console.WriteLine(now.ToString("HH:mm:ss"));
        Console.WriteLine("");

        Console.Write("Data com o mês por extenso:");
        Console.WriteLine(now.ToString("dd MMMM yyyy"));
        Console.WriteLine("");
    }
}
