using System;

class VerificadorParImpar
{
    public static void Executar()
    {
        Console.WriteLine("\n**Verificador de Número Par ou Ímpar**");

        Console.Write("Digite um número inteiro: ");
        if (!int.TryParse(Console.ReadLine(), out int numero))
        {
            Console.WriteLine("Valor inválido! Por favor, digite um número inteiro.");
            return;
        }

        if (numero % 2 == 0)
        {
            Console.WriteLine($"\nO número {numero} é PAR.");
        }
        else
        {
            Console.WriteLine($"\nO número {numero} é ÍMPAR.");
        }
    }
}
