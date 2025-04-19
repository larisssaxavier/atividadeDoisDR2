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
        Console.WriteLine("Exercicio 5 - Conversor de Temperatura");
        Console.WriteLine("Exercicio 6 - Calculo IMC");
        Console.WriteLine("Exercicio 7 - Verificador de Número Par ou Ímpar");
        Console.WriteLine("Exercicio 8 - Classificação de Nota Escolar");
        Console.WriteLine("Exercicio 9 - Calculadora de Salário Líquido");
        Console.WriteLine("Exercicio 10 - Contagem regressiva");
        Console.WriteLine("Exercicio 11 - Tabuada Interativa");
        Console.WriteLine("Exercicio 12 - Jogo de advinhação");

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
            case "5":
                ConversorTemperatura.Executar();
                break;
            case "6":
                CalculadoraIMC.Executar();
                break;
            case "7":
                VerificadorParImpar.Executar();
                break;
            case "8":
                ClassificadorNotas.Executar();
                break;
            case "9":
                CalculadoraSalario.Executar();
                break;
            case "10":
                ContagemRegressiva.Executar();
                break;
            case "11":
                TabuadaInterativa.Executar();
                break;
            case "12":
                Jogo.Executar();
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}