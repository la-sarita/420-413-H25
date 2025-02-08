using System;

namespace Syntaxe
{
    class ChainesDeCaracteres
    {
        public static void ManipulerVariables()
        {
            byte mois = 11;
            short age = 30;
            int quantite = 2560;
            long telephone = 514_000_1111;
            float prix = 14.75F;
            double salaire = 75800.5;
            decimal population = 1_234_654_789;
            char mention = 'A';
            string salutation = "Bonjour tous!";
            string chaineVide = String.Empty;
            const string chemin = @"C:\Program Files\Microsoft Visual Studio 2022";
            var lettre = salutation.ElementAt(0);
            char[] lettres = { 'S', 'a', 'r', 'a' };
            string prenom = new string(lettres);

            Console.WriteLine(mois);
            Console.WriteLine(age);
            Console.WriteLine(quantite);
            Console.WriteLine(telephone);
            Console.WriteLine(prix);
            Console.WriteLine(salaire);
            Console.WriteLine(mention);
            Console.WriteLine(population);
            Console.WriteLine(salutation);
            Console.WriteLine(chaineVide);
            Console.WriteLine(chemin);
            Console.WriteLine(prenom);

        }

        public static void ManipulerChaines()
        {
            string nom = "Sara";
            int age = 48;

            string presentation1 = "Je m'appelle " + nom + ", j'ai " + age + " ans.";
            string presentation2 = string.Format("Je m'appelle {0}, j'ai {1} ans. ", nom, age);
            string presentation3 = $"Je m'appelle {nom}, j'ai {age} ans. ";
            string longMessage = """
                    This is a long message.
                    It has several lines.
                        Some are indented
                                more than others.
                    Some should start at the first column.
                    Some have "quoted text" in them.
                    """;

            var longitude = 73.866555;
            var latitude = 53.566544;
            var tuple = (longitude, latitude);

            var location = $$"""
                           Hello!
                                You are at ({{longitude}}, {{latitude}})
                           """;
            // conversion avec parse
            int age2 = int.Parse("35");
            bool vrai = bool.Parse("true");

            // Conversion avec TryParse
            if (int.TryParse("text", out int age3))
            {
                Console.WriteLine(age3);
            }
            else
            {
                Console.WriteLine("Conversion impossible!");
            }
            Console.WriteLine(age3);
            Console.WriteLine(presentation1);
            Console.WriteLine(presentation2);
            Console.WriteLine(presentation3);
            Console.WriteLine(longMessage);
            Console.WriteLine(location);
            Console.WriteLine(age2);
            Console.WriteLine(vrai);
        }
    }
}
