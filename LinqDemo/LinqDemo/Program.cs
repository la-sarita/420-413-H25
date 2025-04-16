using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        // Source de données
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // Requête LINQ (synthaxe de requête)
        var evenNumbers = from num in numbers
                          where num % 2 == 0
                          select num;
        // Exécution et affichage
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }

        // Syntaxe de méthode
        var evenNumbersSynt2 = numbers.Where(num => num % 2 == 0);
        // Exécution et affichage
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }
    }           // Résultat attendu : 2, 4, 6, 8, 10
}