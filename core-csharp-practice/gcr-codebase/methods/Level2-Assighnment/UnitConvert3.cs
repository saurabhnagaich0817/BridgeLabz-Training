using System;

class UnitConvertor3
{
    public static double ConvertFahrenheitToCelsius(double fahrenheit){
        return (fahrenheit - 32) * 5 / 9;
    }

    public static double ConvertCelsiusToFahrenheit(double celsius){
        return (celsius * 9 / 5) + 32;
    }

    public static double ConvertPoundsToKilograms(double pounds){
        return pounds * 0.453592;
    }

    public static double ConvertKilogramsToPounds(double kilograms)
    {
        return kilograms * 2.20462;
    }

    public static double ConvertGallonsToLiters(double gallons)
    {
        return gallons * 3.78541;
    }

    public static double ConvertLitersToGallons(double liters)
    {
        return liters * 0.264172;
    }

    static void Main()
    {
        Console.WriteLine("F to C: " + ConvertFahrenheitToCelsius(98.6));
        Console.WriteLine("C to F: " + ConvertCelsiusToFahrenheit(37));
        Console.WriteLine("Pounds to Kg: " + ConvertPoundsToKilograms(70));
        Console.WriteLine("Kg to Pounds: " + ConvertKilogramsToPounds(60));
        Console.WriteLine("Gallons to Liters: " + ConvertGallonsToLiters(2));
        Console.WriteLine("Liters to Gallons: " + ConvertLitersToGallons(5));
    }
}
