using System;

class CalculadoraIMC
{
    public static string CalculoIMC(double peso, double altura)
    {
        double imc = peso / (altura * altura);
        string classificacao;

        if (imc < 18.5)
            classificacao = "Abaixo do peso";
        else if (imc < 25)
            classificacao = "Peso normal";
        else if (imc < 30)
            classificacao = "Sobrepeso";
        else if (imc < 35)
            classificacao = "Obesidade Grau I";
        else if (imc < 40)
            classificacao = "Obesidade Grau II";
        else
            classificacao = "Obesidade Grau III (Mórbida)";

        return $"Seu IMC é: {imc:F1}\nClassificação: {classificacao}";
    }

    public static void Executar()
    {
        Console.WriteLine("\n**Calculadora de IMC**");
        Console.Write("Digite seu peso em kg (ex: 68,5): ");

        if (!double.TryParse(Console.ReadLine(), out double peso) || peso <= 0)
        {
            Console.WriteLine("Peso inválido! Digite um valor positivo.");
            return;
        }

        Console.Write("Digite sua altura em metros (ex: 1,75): ");
        if (!double.TryParse(Console.ReadLine(), out double altura) || altura <= 0)
        {
            Console.WriteLine("Altura inválida! Digite um valor positivo.");
            return;
        }

        Console.WriteLine(CalculoIMC(peso, altura));
    }
}