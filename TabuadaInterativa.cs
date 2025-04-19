using System;

class TabuadaInterativa
{
    public static void Executar()
    {
        Console.WriteLine("\n**GERADOR DE TABUADA**");

        Console.Write("Digite um número para a geração da tabuada: ");
        int numero;
        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.Write("Valor inválido! Digite um número inteiro: ");
        }

        Console.WriteLine($"\nTabuada do {numero}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}