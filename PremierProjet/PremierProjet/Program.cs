using CSharpClasses;
using Syntaxe;
using System;
using System.Reflection.Emit;
using static System.Runtime.InteropServices.JavaScript.JSType;
using ClassesAndEnums;
using CSharpArraysAndCollections;

namespace CSharpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SurvolVariables();
            ChainesDeCaracteres.ManipulerChaines();
            SurvolInstructionsControle();
            SurvolInstructionsSaut();
            var result = Calculator.Add(true, 1, 2, 3, 4);
            Console.WriteLine(result);
            string[] cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };
            
            MethodPassingByValueVsByReferece();

            Tableaux.DemoTableaux();
            Listes.DemoListe();
            Dictionnaires.DemoDictionnaires();
        }

        static void DemoEnums()
        {
            Level level = Level.MEDIUM;
            Console.WriteLine(level);
            int val = (int)level;
            Console.WriteLine(val);
            Months mois = Months.AVRIL;
            int val2 = (int)mois;
            Console.WriteLine(val2);

            switch (level)
            {
                case Level.LOW:
                    Console.WriteLine("Low level");
                    break;
                case Level.MEDIUM:
                    Console.WriteLine("Medium level");
                    break;
                case Level.HIGH:
                    Console.WriteLine("High level");
                    break;
            }
        }

        static void MethodPassingByValueVsByReferece()
        {
            int nombre = 10;
            int nombre2;
            MethodPassingParamByValue(nombre);
            Console.WriteLine(nombre);                  // Affiche 10
            MethodPassingParamByRefUsingRef(ref nombre);
            Console.WriteLine(nombre);
            MethodPassingParamByRefUsingOut(out nombre2);
            Console.WriteLine(nombre2);
            MethodPassingParamByRefUsingOut(out int nombre3);
            Console.WriteLine(nombre3);
        }

        static void MethodPassingParamByValue(int var)
        {
            var += 40;
        }

        static void MethodPassingParamByRefUsingRef(ref int var)
        {
            var++;
        }

        static void MethodPassingParamByRefUsingOut(out int var)
        {
            var = 30;
        }

        private static void SurvolInstructionsIteratives()
        {
            InstructionsIteratives.BoucleFor();
            InstructionsIteratives.BoucleWhile();
            InstructionsIteratives.BoucleDoWhile();
            InstructionsIteratives.BoucleForeach();
        }

        private static void SurvolInstructionsControle()
        {
            SurvolInstructionsConditionnelles();
            SurvolInstructionsIteratives();
        }
        
        public static void SurvolInstructionsConditionnelles(){
            InstructionsConditionnelles.InstructionIf();
            InstructionsConditionnelles.InstructionIfElse();
            InstructionsConditionnelles.InstructionIfElseIfElse();
            InstructionsConditionnelles.ExpressionTernaire();
            InstructionsConditionnelles.InstructionSwitch();
            InstructionsConditionnelles.DisplayMeasurements(3, 4);  // Output: First measurement is 3, second measurement is 4.
            InstructionsConditionnelles.DisplayMeasurements(5, 5);  // Output: Both measurements are valid and equal to 5.
        }

        // Exemples de commentaires
        public static int Add(int first, int second)
        {
            return first /* first operand */ + second /* second operand*/;
        }

        public static void SurvolVariables()
        {
            Variables.SurvolSyntaxe();
            Variables.SurvolPortee();
            Variables.RepresentationsDecimale();
            Variables.ShowMessage();
            Console.WriteLine(Add(6, 9));
        }

        public static void SurvolInstructionsSaut()
        {
            InstructionsSaut.InstructionsBreak();
            InstructionsSaut.InstructionsContinue();
            InstructionsSaut.InstructionsBreakBoucleWhile();
            InstructionsSaut.InstructionsContinueBoucleWhile();
        }
    }
}
