using FundamentosCSharp.src.Project01;
using FundamentosCSharp.src.Projeto02;
using FundamentosCSharp.src.Projeto03;
using FundamentosCSharp.src.Projeto04;
using FundamentosCSharp.src.Projeto05;
using FundamentosCSharp.src.Projeto06;

class Program
{
    static void Main()
    {
        Menu();

        int project = ChooseProject();

        switch (project) 
        {
            case 1:
                Welcome.Run();
                break;
            case 2:
                FullName.Run();
                break;
            case 3:
                Calc.Run();
                break;
            case 4:
                CountCharacters.Run();
                break;
            case 5:
                Plate.Run();
                break;
            case 6:
                Datetimer.Run();
                break;
            default:
                Console.WriteLine("Número de projeto inválido");
                break;

        }
    }

    private static int ChooseProject()
    {
        Console.Write("Digite o número do projeto que você deseja executar: ");
        var project = int.Parse(Console.ReadLine()!);
        Console.WriteLine("");

        return project;
    }

    private static void Menu()
    {
        Console.WriteLine("");
        Console.WriteLine("==== Projetos ====");
        Console.WriteLine("");
        Console.WriteLine("1 - Boas vindas");
        Console.WriteLine("2 - Nome completo");
        Console.WriteLine("3 - Calculos");
        Console.WriteLine("4 - Quantidade caracteres");
        Console.WriteLine("5 - Placa de veículo");
        Console.WriteLine("6 - Exibição de datas");
        Console.WriteLine("");
    }
}