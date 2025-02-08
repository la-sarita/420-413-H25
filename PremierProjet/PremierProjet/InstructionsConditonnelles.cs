using System;

namespace CSharpBasics
{
    internal class InstructionsConditionnelles
    {
        /*
            if (Some boolean expression){
                // Other statments
            } else if (Other boolean expression)
            {
                // Other statments
            } else
            {
                // Other statments
            }
        */

        public static void InstructionIf()
        {
            int nombre = 8;

            if (nombre % 2 == 0)
            {
                Console.WriteLine($"{nombre} est un nombre pair");
            }
        }

        public static void InstructionIfElse()
        {
            int nombre = 8;

            if (nombre % 2 == 0)
            {
                Console.WriteLine($"{nombre} est un nombre pair");
            }
            else
            {
                Console.WriteLine($"{nombre} est un nombre impair");
            }
        }

        public static void InstructionIfElseIfElse()
        {
            int nombre = 9;

            if (nombre < 5)
            {
                Console.WriteLine($"{nombre} est plus petit que 5");
            }
            else if (nombre == 5)
            {

                Console.WriteLine($"{nombre} est égal à 5");
            }
            else
            {
                Console.WriteLine($"{nombre} est plus grand que 5");
            }
        }

        public static string ExpressionTernaire()
        {
            int nombre = 8;
            string messagePair = $"{nombre} Est un nombre ";
            /*

            if (nombre % 2 == 0)
            {
                messagePair += "pair";
            }
            else
            {
                messagePair += "impair";
            }
            */

            messagePair += nombre % 2 == 0 ? "pair" : "impair";

            return messagePair;
        }

        public static void InstructionSwitch()
        {
            /*
            switch (expression)
            {
                case constant expression expression 1:
                    // Other statments
                    break;
                case relational expression expression 2:
                    // Other statments
                    break;
                ...
                default:
                    // Other statments
                    break;
            }
            */

            int jour = 3;

            switch (jour)
            {
                case 1:
                    Console.WriteLine("Lundi");
                    break;
                case 2:
                    Console.WriteLine("Mardi");
                    break;
                case 3:
                    Console.WriteLine("Mercredi");
                    break;
                case 4:
                    Console.WriteLine("Jeudi");
                    break;
                case 5:
                    Console.WriteLine("Vendredi");
                    break;
                case 6:
                    Console.WriteLine("Samedi");
                    break;
                case 7:
                    Console.WriteLine("Dimance");
                    break;
                default:
                    Console.WriteLine("Ce n'Est pas un nombre valide");
                    break;
            }
        }

        public static void DisplayMeasurements(int a, int b)
        {
            switch ((a, b))
            {
                case ( > 0, > 0) when a == b:
                    Console.WriteLine($"Both measurements are valid and equal to {a}.");
                    break;

                case ( > 0, > 0):
                    Console.WriteLine($"First measurement is {a}, second measurement is {b}.");
                    break;

                default:
                    Console.WriteLine("One or both measurements are not valid.");
                    break;
            }
        }
    }
}
