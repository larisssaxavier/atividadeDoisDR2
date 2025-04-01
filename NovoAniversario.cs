using System;

public static class NovoAniversario
{   
    public static DateTime obtemDataNascimento()
    {
        Console.WriteLine("--CALCULADORA DE DIAS ATÉ SEU ANIVERSÁRIO--");
        DateTime dateBirth;
        while (true)
        {   
            Console.WriteLine("Digite sua data de nascimento: dd/mm/aaaa");
            if (DateTime.TryParse(Console.ReadLine(), out dateBirth))
            {
                if (dateBirth > DateTime.Today)
                {
                    Console.WriteLine("Data de nascimento está no futuro!");
                }
                else
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine("Formato de data inválido! Digite novamente uma data no formato dd/mm/aaaa.");
            }
        }
       return dateBirth;
    }

    public static void Executar()
    {
        DateTime dateBirth = obtemDataNascimento();
        DateTime hoje = DateTime.Today;
        DateTime proximoAniversario = new DateTime(hoje.Year, dateBirth.Month, dateBirth.Day);

        if (proximoAniversario < hoje)
        {
            proximoAniversario = proximoAniversario.AddYears(1);
        }

        int diasrestantes = (proximoAniversario - hoje).Days;

        Console.WriteLine($"Faltam {diasrestantes} dias para o seu aniversário!");

        if (diasrestantes == 0)
        {
            Console.WriteLine("Hoje é seu aniversário! Parabéns...");
        }
    }
            
 }
