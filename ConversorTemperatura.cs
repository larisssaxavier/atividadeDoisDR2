using System;

class ConversorTemperatura
{
    public static string CalculoTemperatura(double temperatura)
    {
        double fahrenheit = temperatura * 9.0 / 5.0 + 32;
        double kelvin = temperatura + 273.15;

        return $"\nValores da conversão: \nCelsius: {temperatura:F2}°C\nFahrenheit: {fahrenheit:F2}°F\nKelvin: {kelvin:F2}K";
    }
    public static void Executar()
    {
        Console.WriteLine("\n**Conversor de Temperatura**");

        Console.Write("Digite a temperatura em graus Celsius: ");
        if (!double.TryParse(Console.ReadLine(), out double celsius))
        {
            Console.WriteLine("Valor inválido! Por favor, digite um número.");
            return;
        }

        Console.WriteLine(CalculoTemperatura(celsius));
    }
}