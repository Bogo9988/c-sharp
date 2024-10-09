//using System;

/*
public class Program
{
    static void Main()
    {
        // Pobieranie wagi
        Console.Write("Podaj swoją wagę (w kilogramach np. 75): ");
        double waga = double.Parse(Console.ReadLine());

        // Pobieranie wzrostu
        Console.Write("Podaj swój wzrost (w metrach np. 1,82): ");
        double wzrost = double.Parse(Console.ReadLine());

        // Obliczanie BMI
        double bmi = waga / (wzrost * wzrost);

        // Wyświetlanie wyniku z dokładnością do dwóch miejsc po przecinku
        Console.WriteLine($"Twoje BMI wynosi: {bmi:F2}");
    }
}
*/


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Tworzenie słownika angielsko-polskiego
        Dictionary<string, string> slownik = new Dictionary<string, string>();

        // Dodawanie 5 słów do słownika
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Dodaj słowo angielskie: ");
            string slowoAngielskie = Console.ReadLine();

            Console.Write("Dodaj tłumaczenie: ");
            string tlumaczeniePolskie = Console.ReadLine();

            slownik.Add(slowoAngielskie, tlumaczeniePolskie);
        }

        // Wyszukiwanie tłumaczenia
        Console.Write("Podaj słowo po angielsku: ");
        string slowoDoTlumaczenia = Console.ReadLine();

        // Sprawdzanie, czy słowo istnieje w słowniku
        if (slownik.ContainsKey(slowoDoTlumaczenia))
        {
            Console.WriteLine($"Tłumaczenie: {slownik[slowoDoTlumaczenia]}");
        }
        else
        {
            Console.WriteLine("Słowo nie istnieje w słowniku.");
        }
    }
}

