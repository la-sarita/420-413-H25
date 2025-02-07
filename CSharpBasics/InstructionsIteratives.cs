using System;

namespace CSharpBasics
{
    internal class InstructionsIteratives
    {
        public static void BoucleFor()
        {
            for (int nombre = 0; nombre < 5; nombre++)
            {
                Console.WriteLine(nombre);
            }
        }

        public static void BoucleWhile()
        {
            int i = 0;

            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public static void BoucleDoWhile()
        {
            int i = 0;

            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);
        }

        public static void BoucleForeach()
        {
            string salutation = "Bonjour";

            foreach (char lettre in salutation)
            {
                Console.WriteLine(lettre);
            }
        }

    }

}
