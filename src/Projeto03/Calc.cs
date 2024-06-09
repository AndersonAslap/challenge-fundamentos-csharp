namespace FundamentosCSharp.src.Projeto03;
static class Calc
{
    public static void Run()
    {
        var (value1, value2) = GetValues();

        var plus = Plus(value1, value2);
        var minus = Minus(value1, value2);
        var times = Times(value1, value2);
        var divided = Divided(value1, value2);
        var avg = Avg(value1, value2);

        Console.WriteLine("");
        Console.WriteLine($"A soma é : {plus}");
        Console.WriteLine($"A subtração é : {minus}");
        Console.WriteLine($"A multiplicação é : {times}");
        Console.WriteLine($"A divisão é : {divided}");
        Console.WriteLine($"A média é : {avg}");
        Console.WriteLine("");
    }

    static double Plus(double value1, double value2)
    { 
        return value1 + value2;
    }

    static double Minus(double value1, double value2)
    {
        return value1 - value2;
    }

    static double Times(double value1, double value2)
    {
        return value1 * value2;
    }

    static double Divided(double value1, double value2)
    {
        if (value2 == 0) return 0;
        return value1 / value2;
    }

    static double Avg(double value1, double value2)
    {
        return Plus(value1, value2) / 2;
    }

    static (double, double) GetValues()
    {
        Console.WriteLine("Digite 2 números, para separar a casa decimal utilize (.) ponto: ex: 3.14");
        Console.Write("Digite o primeiro número: ");
        var value1 = double.Parse(Console.ReadLine()!);
        Console.Write("Digite o segundo número: ");
        var value2 = double.Parse(Console.ReadLine()!);

        return (value1, value2);
    }
}
