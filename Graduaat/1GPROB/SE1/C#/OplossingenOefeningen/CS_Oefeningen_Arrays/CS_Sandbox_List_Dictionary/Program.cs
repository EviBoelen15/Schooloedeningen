using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Kies hier de datatypes van de key en value in deze volgorde.
        Dictionary<string, int> punten = new Dictionary<string, int>();

        // Voeg elementen toe aan dictionary: key is naam (string), value is punten (int)
        punten.Add("Tom", 18);
        punten["Sven"] = 20; // toevoegen kan ook op deze manier.

        // Opzoeken
        int getal = punten["Tom"];

        // Proberen opzoeken
        bool isGevonden = punten.TryGetValue("Tommy", out getal);
        isGevonden = punten.TryGetValue("Tom", out getal);

        // Element verwijderen uit dictionary
        bool isVerwijderd = punten.Remove("Sven");

        // Controleren of element bestaat in de dictionary
        bool bestaat = punten.ContainsKey("Tom");


        // Loopen over dictionary en keys en values opvragen van elk item
        foreach (var item in punten)
            Console.WriteLine($"{item.Key}: {item.Value}/20");




        Console.ReadLine();
    }
}



