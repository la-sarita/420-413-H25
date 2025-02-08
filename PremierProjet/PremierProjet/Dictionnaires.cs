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
            int[] nombres = { 5, 6, 5, 2, 1, 5, 4, 3, 2, 5 };
            AfficherValeurPlusFrequante(nombres);
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