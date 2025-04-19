using System;

class ContagemRegressiva
{
    public static void Executar()
    {
        Console.WriteLine("\n**CONTAGEM REGRESSIVA**");

        Console.Write("Digite um número inteiro positivo: ");
        int numero;
        while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
        {
            Console.Write("Valor inválido! Digite um número inteiro positivo: ");
        }

        Console.Write("\nContagem regressiva: ");
        for (int i = numero; i >= 0; i--)
        {
            Console.Write(i);
            if (i > 0)
            {
                Console.WriteLine("\n");
            }
        }

        Console.WriteLine("\n\nFim da contagem!");
    }
}
