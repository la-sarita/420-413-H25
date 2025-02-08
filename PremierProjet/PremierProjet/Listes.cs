using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpArraysAndCollections
{
    internal class Listes
    {
        public static void DemoListe()
        {
            List<int> nombres = new List<int>();
            nombres.Add(15);
            Console.WriteLine(nombres.Count);
            nombres.Add(8);
            Console.WriteLine(nombres.Count);
            nombres.Add(-5);
            Console.WriteLine(nombres.Count);

            foreach (var nombre in nombres)
            {
                Console.Write(nombre + ", ");
            }
            Console.WriteLine();

            var caracteres = new List<char> { 'A', 'B', 'C' };

            for (int i = 0; i < caracteres.Count; i++)
            {
                Console.Write(caracteres[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < caracteres.Count; i++)
            {
                Console.Write(caracteres.ElementAt(i) + " ");
            }

            Console.WriteLine();

            string[] cities = { "Mumbai", "London", "New York" };
            List<string> popularCities = new List<string>();
            Console.WriteLine(popularCities.Count);
            
            // Ajouter le tableau dans la liste
            popularCities.AddRange(cities);
            Console.WriteLine(popularCities.Count);
            popularCities.Add("Montreal");
            Console.WriteLine(popularCities.Count);
            var favouriteCities = new List<string>();
            
            // Ajouter une liste à la nouvelle liste
            favouriteCities.AddRange(popularCities);
            Console.WriteLine(favouriteCities.Count);
            favouriteCities.Add("Algers");
            Console.WriteLine(favouriteCities.Count);

            List<int> numbers = new List<int> { 10, 50, 30, 40 };
            AfficherElement(numbers);
            numbers.Insert(2, 80);
            numbers.InsertRange(1, new int[] { 5, 9, 10 });
            AfficherElement(numbers);
            numbers.RemoveAt(3);
            AfficherElement(numbers);
            bool estRetire = numbers.Remove(100);
            Console.WriteLine(estRetire ? "" : "L'element n'existe pas");
            Console.WriteLine(estRetire);
            
            if (numbers.Contains(100))
            {
                numbers.Remove(100);
            }
            else
            {
                Console.WriteLine("L'element n'existe pas");
            }
            estRetire = numbers.Remove(10);
            Console.WriteLine(estRetire);
            AfficherElement(numbers);
            
            numbers.ForEach(x =>
            {
                x++;
                Console.Write(x + " ");
            });
            
            numbers.ForEach(x => Doubler(x));
            Console.WriteLine();
            //numbers.Clear();
            Console.WriteLine(numbers.Count);
            numbers.Reverse();
            AfficherElement(numbers);
            numbers.Sort();
            AfficherElement(numbers);
        }

        public static int Doubler(int x)
        {
            return x * 2;
        }

        public static void AfficherElement(List<int> liste)
        {
            for (int i = 0; i < liste.Count; i++)
            {
                Console.Write(liste[i] + " ");
            }
            Console.WriteLine();
        }

        public static void AfficherElement(List<string> liste)
        {
            for (int i = 0; i < liste.Count; i++)
            {
                Console.WriteLine(liste[i]);
            }
        }

        public static void InsererElements()
        {
            const string msgInvit = "Veuillez entrer un nombre ou \"fin\" pour terminer le programme";
            const string msgErreur = "Entrée invalide!";
            string entree;
            int nombre;
            List<int> liste = new List<int>();
            
            do
            {
                Console.WriteLine(msgInvit);
                entree = Console.ReadLine();
                if (entree.ToLower().Equals("fin"))
                {
                    break;
                }
                else
                {
                    if (int.TryParse(entree, out nombre))
                    {
                        liste.Add(nombre);
                    }
                    else
                    {
                        Console.WriteLine(msgErreur);
                    }
                }
            } while (!entree.ToLower().Equals("fin"));
            
            // Affichage des statistiques 
            Console.WriteLine($"La somme des nombres est : {liste.Sum()}\n" +
                $"La moyenne est : {liste.Average()}\n" +
                $"Le plus grand nombre est : {liste.Max()}\n" +
                $"Le plus petit nombre est : {liste.Min()}");
        }
    }
}
