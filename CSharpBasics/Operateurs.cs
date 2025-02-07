using System;

namespace CSharpBasics
{
    internal class Operateurs
    {
        public static void calcul()
        {
            int addition = 5 + 2; // 7
            int soustraction = 5 - 2; // 3
            int mult = 5 * 2; // 10
            int div = 6 / 2; // 3
            var modulo = 5.0 % 2; // 1

            Console.WriteLine("Opérateurs de calcul");
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}",
                addition, soustraction, mult, div, modulo);
        }

        public static void incrementation()
        {
            Console.WriteLine("Opérateur d'incrémentation suffixé");
            int i = 3;
            Console.WriteLine(i);   // output: 3
            Console.WriteLine(i++); // output: 3
            Console.WriteLine(i);   // output: 4

            Console.WriteLine("Opérateur d'incrémentation préfixé");
            double a = 1.5;
            Console.WriteLine(a);   // output: 1.5
            Console.WriteLine(++a); // output: 2.5
            Console.WriteLine(a);   // output: 2.5
        }

        public static void decrementation()
        {
            Console.WriteLine("Opérateur de décrémentation suffixé");
            int i = 3;

            Console.WriteLine(i);   // output: 3
            Console.WriteLine(i--); // output: 3
            Console.WriteLine(i);   // output: 2

            Console.WriteLine("Opérateur de décrémentation préfixé");
            double a = 1.5;

            Console.WriteLine(a);   // output: 1.5
            Console.WriteLine(--a); // output: 0.5
            Console.WriteLine(a);   // output: 0.5
        }

        public static void assignation()
        {
            int nombre = 5;

            Console.WriteLine("Opérateur d'assignation");

            nombre += 1; // nombre devient 6;
            nombre -= 2; // nombre devient 4;
            nombre *= 3; // nombre devient 12
            nombre /= 2; // nombre devient 6
            nombre %= 5;// nombre devient 1
        }

        public static void logique()
        {
            // TODO : ajouter des exemples
        }
        public static void comparaison()
        {
            int x = 3, y = 8;

            Console.WriteLine(x == y); // retourne true si x est égale à y
            Console.WriteLine(x != y); // retourne true si x est différent de y
            Console.WriteLine(x > y); // retourne true si x est supérieur à y
            Console.WriteLine(x >= y); // retourne true si x est supérieur ou égale à y
            Console.WriteLine(x < y); // retourne true si x est inférieur  à y
            Console.WriteLine(x <= y); // retourne true si x est inférieur ou égale à y
            Console.WriteLine(x is int); // retourne true si x est du type int
            Console.WriteLine((x >= 0 || x > 10) && (x <= 1 || x < 25)); // combinaison de plus qu'une expression
        }


    }
}
