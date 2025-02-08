using System;


namespace CSharpBasics
{
    internal class Variables
    {
        static string firstName = "Sara";
        static int count = 25;                      // integer is the data type by default used for representing the integral numbers
        static float temperature = 34.4f;           // If we don't add the f or F after the value we will get an error
                                                    // (defaut value is double and double is bigger than a float)
        public static void SurvolSyntaxe()
        {
            byte number = 2;
            Console.WriteLine(number);           // Console use the System
            double amount = 180065.75;           // double is the data type by default used for representing the real numbers
            decimal biggerAmount = 5_654_500_866.85m;     // decimal is the biggest type used for representing the real numbers
            char caractere = 'S';
            bool isActive = false;
            var anotherChar = 'D';

            Console.WriteLine($"{firstName}");
            Console.WriteLine("{0} - {1} - {2} - {3} - {4} - {5} - {6} - {7}",
                number, count, temperature, amount, biggerAmount, caractere, isActive, anotherChar);
            Console.WriteLine("{0} {1}", decimal.MinValue, decimal.MaxValue);

        }

        public static void SurvolPortee()
        {
            for (int i = 0; i < 5; i++)
            {
                int multiple = i * 6;
                Console.WriteLine(multiple);
            }
        }

        public static void RepresentationsDecimale()
        {
            int nombre1 = 10; //Notation décimale
            int nombre2 = 0x4B; // Notation hexadécimale équivalente à 75
            int nombre3 = 0b1101; // Notation binaire équivalente à 13
        }

        // exemple affichage variables
        public static void ShowMessage()
        {
            Console.WriteLine("Hello, {0}! You have {1} messages in your inbox. The temperature is {2} celsius.", firstName, count, temperature);
        }
    }
}
