// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main()
    {
        Console.WriteLine("Qual exercicio deseja executar?");
        Console.WriteLine("Exercicio 1 - Calculadora de idade");
        Console.WriteLine("Exercicio 2 - Calculadora de dias restantes aniversário");
        Console.WriteLine("Exercicio 3 - Calculadora de diferença entre datas");
        Console.WriteLine("Exercicio 4 - Formulário de cadastro");

        var opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                CalculoIdade.Executar();
                break;
            case "2":
                NovoAniversario.Executar();
                break;
            case "3":
                DiferencaDatas.Executar();
                break;
            case "4":
                FormularioCadastro.Executar();
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}