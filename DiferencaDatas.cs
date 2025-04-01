using System;

public static class DiferencaDatas
{
    public static DateTime obterData(string mensagem)
    {
        DateTime data;

        Console.Write(mensagem);
        while (true)
        {
            if (DateTime.TryParse(Console.ReadLine(), out data))
            {
                return data;
            }
            else
            {
                Console.WriteLine("Data inválida! Digite novamente a data no formato dd/mm/aaaa");
            }

        }
    }

    public static (int anos, int meses, int dias) CalculoDiferenca (DateTime dataInicial, DateTime dataFinal)
    {
        int anos = dataFinal.Year - dataInicial.Year;
        int meses = dataFinal.Month - dataInicial.Month;
        int dias = dataFinal.Day - dataInicial.Day;

        if (dias < 0)
        {
            meses--;
            DateTime ultimoDiaMesAnterior = new DateTime(dataFinal.Year,dataFinal.Month,1).AddDays(-1);
            dias += DateTime.DaysInMonth(ultimoDiaMesAnterior.Year, ultimoDiaMesAnterior.Month);
        }

        if (meses < 0)
        {
            anos--;
            meses += 12;
        }
        return (anos, meses, dias);
    }

    public static void Executar()
    {
        Console.WriteLine("--CALCULO DE DIFERENÇA DE DATAS--");
        DateTime dataUm = obterData("Digite a primeira data: ");
        DateTime dataDois = obterData("Digite a segunda data: ");

        if (dataUm > dataDois)
        {
            DateTime correcao = dataUm;
            dataUm = dataDois;
            dataDois = correcao;
        }

        var diferenca = CalculoDiferenca(dataUm, dataDois);
        Console.WriteLine($"Diferença entre datas: {diferenca.anos} anos, {diferenca.meses} meses, {diferenca.dias} dias");
    }
}
