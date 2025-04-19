using System;

class ClassificadorNotas
{
    public static string Classificador(double nota)
    {
        string status;
        if (nota < 5)
        {
            status = "Insuficiente";
        }
        else if (nota < 7)
        {
            status = "Regular";
        }
        else if (nota < 9)
        {
            status = "Bom";
        }
        else
        {
            status = "Excelente";
        }

        return $"\nNota {nota:F1}: {status.ToUpper()}";
    }
    public static void Executar()
    {
        Console.WriteLine("\nClassificação de Notas Escolares");

        Console.Write("\nDigite uma nota entre 0 e 10: ");
        if (!double.TryParse(Console.ReadLine(), out double nota) || nota < 0 || nota > 10)
        {
            Console.WriteLine("Nota inválida! Digite um valor entre 0 e 10.");
            return;
        }

        Console.WriteLine(Classificador(nota));
    }
}

