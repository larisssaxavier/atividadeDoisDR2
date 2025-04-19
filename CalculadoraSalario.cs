using System;

class CalculadoraSalario
{
    public static void Executar()
    {
        Console.WriteLine("\n**CÁLCULO DE SALÁRIO LÍQUIDO**");

        Console.Write("Digite seu salário bruto (R$): ");
        decimal salarioBruto;
        while (!decimal.TryParse(Console.ReadLine().Replace(".", ","), out salarioBruto) || salarioBruto <= 0)
        {
            Console.Write("Valor inválido! Digite um valor positivo (ex: 3500,50): ");
        }

        (decimal inss, decimal irrf) = CalcularDescontos(salarioBruto);
        decimal salarioLiquido = salarioBruto - inss - irrf;

        Console.WriteLine("\nRESUMO");
        Console.WriteLine("------");
        Console.WriteLine($"Salário Bruto: {salarioBruto:C2}");
        Console.WriteLine($"- INSS: {inss:C2}");
        Console.WriteLine($"- IRRF: {irrf:C2}");
        Console.WriteLine($"Salário Líquido: {salarioLiquido:C2}");

    }

    private static (decimal inss, decimal irpf) CalcularDescontos(decimal salario)
    {
        decimal inss = CalcularINSS(salario);
        decimal baseIrpf = salario - inss;
        decimal irpf = CalcularIRPF(baseIrpf);

        return (inss, irpf);
    }

    public static decimal CalcularINSS(decimal salario)
    {
        if (salario <= 1518.00m)
        {
            return salario * 0.075m;
        }

        else if (salario <= 2793.88m)
        {
            return salario * 0.09m;
        }

        else if (salario <= 4190.83m)
        {
            return salario * 0.12m;
        }

        else if (salario <= 8157.41m)
        {
            return salario * 0.14m;
        }
        else
        {
            return 951.62m;
        }
        return 0m;
    }

    public static decimal CalcularIRPF(decimal baseCalculo)
    {
        if (baseCalculo <= 2428.80m)
        {
            return 0m;
        }

        else if (baseCalculo <= 2826.65m)
        {
            return baseCalculo * 0.075m;
        }

        else if (baseCalculo <= 3751.05m)
        {
            return baseCalculo * 0.15m;
        }

        else if (baseCalculo <= 4664.68m)
        {
            return baseCalculo * 0.225m;
        }
        else
        {
            return baseCalculo * 0.275m;
        }
        return 0m;
    }
}
