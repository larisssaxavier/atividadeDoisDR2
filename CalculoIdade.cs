using System;

public static class CalculoIdade
{
    public static (int anos, int meses, int dias) CalculaIdade(DateTime dataNascimento)
    {
        DateTime dataAtual = DateTime.Today;

        int anos = dataAtual.Year - dataNascimento.Year;
        int meses = dataAtual.Month - dataNascimento.Month;
        int dias = dataAtual.Day - dataNascimento.Day;

        if (dias < 0)
        {
            meses--;
            int mesAnterior = dataAtual.Month - 1;
            int anoAnterior = dataAtual.Year;

            if (mesAnterior < 1)
            {
                mesAnterior = 12;
                anoAnterior--;
            }

            dias += DateTime.DaysInMonth(anoAnterior, mesAnterior);
        }
        if (meses < 0)
        {
            anos--;
            meses += 12;
        }
        return (anos, meses, dias);
    }

    public static DateTime obterDataNascimento()
    {
        DateTime dataNascimento;

        Console.WriteLine("--Calculdora de idade precisa--");

        while (true)
        {
            Console.Write("Digite sua data de nascimento (dd/mm/aaaa): ");

            if (DateTime.TryParse(Console.ReadLine(), out dataNascimento))
            {
                if (dataNascimento > DateTime.Today)
                {
                    Console.WriteLine("A data que digitou está no futuro! Insira uma data válida.");
                }
                else
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine("Formato inválido! Insira uma data no formato dd/mm/aaaa.");
            }
        }
        return dataNascimento;
    }
    
        public static void Executar()
    {
        DateTime dataNasc = obterDataNascimento();
        var idade = CalculaIdade(dataNasc);
        Console.WriteLine("\n Sua idade exata é: ");
        Console.WriteLine($"{idade.anos} anos {idade.meses} meses e {idade.dias} dias");
    }
}