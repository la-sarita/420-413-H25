using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpArraysAndCollections
{
    internal class Tableaux
    {
        public static void DemoTableaux()
        {
            /*
             * Tableaux d'une dimension
             */
            // Déclaration d'un tableau
            string[] couleurs;
            couleurs = new string[3] { "rouge", "bleu", null };
            // Réinitialiser le tableau couleurs
            couleurs = new string[5] { "rouge", "bleu", "vert", "blanc", "jaune" };

            // Déclaration et initialisation d'un tableau
            string[] voitures = { "Volvo", "BMW", "Mazda", "Opel" };
            int[] nombres = { 10, 20, 0, 50 };
            // Accès aux éléments d'un tableau
            string premiereVoiture = voitures[0];
            Console.WriteLine(premiereVoiture);
            // Déclaration d'un tableau de longueur 5
            int[] tab = new int[5];
            // Modification de la valeur du 1er élément (pos = 0)
            tab[0] = 1;
            // Modifier une valeur
            voitures[0] = "Ford";
            Console.WriteLine("La première voiture est " + voitures[0]);
            Console.WriteLine(voitures.Length);
            int[] numeros = new int[4];
            string[] cars = new string[3];
            for (int i = 0; i < voitures.Length; i++)
            {
                Console.WriteLine("On affiche la voiture #" + (i + 1) + " qui est : " + voitures[i]);
            }

            foreach (string voiture in voitures)
            {
                Console.WriteLine(voiture);
            }

            /*
             * Chaines de caractères quelques méthodes
             */
            string salutation = "Bonjour tout le monde!";
            string[] mots = salutation.Split(' ');
            Console.WriteLine(mots.Length);
            foreach (string mot in mots)
            {
                Console.WriteLine(mot);
            }

            string phrase = "CECI_EST_LE_NOM_DU_FICHIER";
            string[] phraseSeparee = phrase.Split('_');
            foreach (string word in phraseSeparee)
            {
                Console.WriteLine(word);
            }

            string chaine = phrase.Substring(4, 6);
            Console.WriteLine(chaine);
            char[] lettres = chaine.ToCharArray();
            Console.WriteLine(lettres.Length);
            foreach (char lettre in lettres)
            {
                Console.WriteLine(lettre);
            }

            string unePhraseAvecEspaces = "     Bonjour  !     ";
            Console.WriteLine(unePhraseAvecEspaces);
            Console.WriteLine(unePhraseAvecEspaces.Length);
            Console.WriteLine(unePhraseAvecEspaces.Trim());
            Console.WriteLine(unePhraseAvecEspaces.Trim().Length);
        }
    }
}
