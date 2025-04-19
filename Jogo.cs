using System;

class Jogo
{
    public static void Executar()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);
        int tentativas = 0;
        int palpite;

        Console.WriteLine("\n***JOGO DE ADIVINHAÇÃO***");
        Console.WriteLine("Tente adivinhar o número gerado entre 1 e 100!\n");

        do
        {
            Console.Write("Digite seu palpite: ");

            while (!int.TryParse(Console.ReadLine(), out palpite) || palpite < 1 || palpite > 100)
            {
                Console.Write("Por favor, digite um número válido entre 1 e 100: ");
            }

            tentativas++;

            if (palpite < numeroSecreto)
            {
                Console.WriteLine("O número secreto é MAIOR que " + palpite + "\n");
            }
            else if (palpite > numeroSecreto)
            {
                Console.WriteLine("O número secreto é MENOR que " + palpite + "\n");
            }

        } while (palpite != numeroSecreto);

        Console.WriteLine("\nPARABÉNS! Você acertou o número gerado " + numeroSecreto + " em " + tentativas + " tentativas!");
    }
}