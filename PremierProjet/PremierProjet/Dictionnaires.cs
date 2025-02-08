using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpArraysAndCollections
{
    internal class Dictionnaires
    {
        public static void DemoDictionnaires()
        {
            CreerDict();

            var cities = new Dictionary<string, string> {
                {"UK", "London, Manchester, Birmingham" },
                {"USA", "Chicago, New York, Washigton" },
                {"India", "Mumbai, New Delhi, Pune" }
            };

            ManipulerDictionnaire(cities);

            int[] nombres = { 5, 6, 5, 2, 1, 5, 4, 3, 2, 5 };
            AfficherValeurPlusFrequante(nombres);
        }

        public static void CreerDict()
        {
            // Création d'un dictionnaire
            Dictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "Un");
            numberNames.Add(2, "Deux");
            numberNames.Add(3, "Trois");
            // Accès aux éléments d'un dictionnaire
            foreach (KeyValuePair<int, string> item in numberNames)
            {
                Console.WriteLine("L'element avec la clé {0} et la valeur {1}", item.Key, item.Value);
            }
        }

        public static void ManipulerDictionnaire(Dictionary<string, string> cities)
        {
            AccederElements(cities);
            AccederClesValeurs(cities);
            VerfierCleExists(cities);
            MettreAJourDict(cities);
            SupprimerElements(cities);
        }

        public static void AccederClesValeurs(Dictionary<string, string> cities)
        {
            var villes = cities.Values;
            foreach (var ville in villes)
            {
                Console.WriteLine(ville);
            }
            
            var keys = cities.Keys;
            foreach (var key in keys)
            {
                Console.WriteLine(key);
            }
        }

        public static void AccederElements(Dictionary<string, string> cities)
        {
            Console.WriteLine(cities.First().Value);
            Console.WriteLine(cities.Last().Key);
            
            for (int i = 0; i < cities.Count; i++)
            {
                var elem = cities.ElementAt(i);
                Console.WriteLine("Les grandes villes de {0} sont : {1}", elem.Key, elem.Value);
            }
            
            // accès par la clé
            string ukCities = cities["UK"];
            
            // accés par la position
            Console.WriteLine(cities.ElementAt(0).Value);
            Console.WriteLine(ukCities);
        }
        
        public static void VerfierCleExists(Dictionary<string, string> cities) 
        {
            // Vérifier que la clé exsiste avant d'accéder à
            // la valeur contenue dans l'élément qui a cette clé
            if (cities.ContainsKey("France"))
            {
                cities["France"] = "Paris";
                Console.WriteLine(cities["France"]);
            }
            else
            {
                Console.WriteLine("Le pays n'existe pas!");
            }

            // Vérifier que la clé exsiste si oui sa valeur sera stockée dans la variable valeur
            if (cities.TryGetValue("Lune", out string valeur))
            {
                Console.WriteLine(valeur);
            }
            else
            {
                Console.WriteLine("Désolé! Ce pays n'existe pas!");
            }
        }

        public static void MettreAJourDict(Dictionary<string, string> cities)
        {
            // Mettre à jour le dictonnaire
            cities["UK"] = "Liverpool, Bristol";
            Console.WriteLine(cities["UK"]);
            //Console.WriteLine(cities["France"]); // cette ligne lance une exception car la clé
            //"France" n'existe pas encore
            cities["France"] = "Paris, Lion";
            Console.WriteLine(cities["France"]);
        }

        public static void SupprimerElements(Dictionary<string, string> cities)
        {
            bool estRetire = cities.Remove("Lune");
            string message = estRetire ? "Le pays a été retiré" : "Le pays n'a pas pu être retiré";
            Console.WriteLine(cities.ContainsValue("Paris"));
            estRetire = cities.Remove("France");
            Console.WriteLine(cities.ContainsValue("Paris"));
            Console.WriteLine(message);
            Console.WriteLine("Dans notre dictionnaire il y a " +
                cities.Count + " ville" + (cities.Count > 1 ? "s" : ""));
            
            cities.Clear();
            Console.WriteLine(cities.Count);
        }

        public static void AfficherValeurPlusFrequante(int[] nombres)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (var nombre in nombres)
            {
                if (dict.ContainsKey(nombre))
                {
                    dict[nombre]++;
                }
                else
                {
                    dict.Add(nombre, 1);
                }
            }

            KeyValuePair<int, int> nbrPlusFreq = dict.ElementAt(0);
            foreach (var item in dict)
            {
                if (item.Value > nbrPlusFreq.Value)
                {
                    nbrPlusFreq = item;
                }
            }

            Console.WriteLine($"Le nombre le plus fréquent est : {nbrPlusFreq.Key}" +
                $", il est apparu {nbrPlusFreq.Value} fois.");
            Console.WriteLine(dict.Values.Max());
        }
    }
}