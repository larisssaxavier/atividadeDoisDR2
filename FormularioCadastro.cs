using System;

public static class FormularioCadastro
{
    public static int lerInteiro()
    {
        int resultado;

        while (!int.TryParse(Console.ReadLine(), out resultado))
        {
            Console.WriteLine("Idade inválida! Digite um número positivo:");
        }
        return resultado;
    }

    public static string formatarTelefone(string telefone)
    {
        telefone = new string(telefone.Where(char.IsDigit).ToArray());

        if (telefone.Length == 11)
        {
            return $"({telefone[..2]}) {telefone.Substring(2, 5)} - {telefone[7..]}";
        }
        else if (telefone.Length == 10)
        {
            return $"({telefone[..2]}) {telefone.Substring(2, 4)} - {telefone[6..]}";
        }
        else
        {
            return telefone;
        }
    }

    public static void Executar()
    {
        Console.WriteLine("--CADASTRO DE USUÁRIO--");
        Console.WriteLine("Por favor informa os dados abaixo: ");
        Console.Write("Nome completo: ");
        string nome = Console.ReadLine();
        Console.Write("Idade: ");
        int idade = lerInteiro();
        Console.Write("Telefone com DDD: ");
        string telefone = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();

        Console.WriteLine("\nINFORMAÇÕES CADASTRADAS");
        Console.WriteLine($"Nome:    {nome}");
        Console.WriteLine($"Idade:   {idade} anos");
        Console.WriteLine($"Telefone: {formatarTelefone(telefone)}");
        Console.WriteLine($"E-mail:  {email}");
    }
}
