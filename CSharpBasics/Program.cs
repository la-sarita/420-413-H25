using System;

namespace CSharpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SurvolVariables();
            SurvolInstructionsControle();
            SurvolInstructionsSaut();
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
