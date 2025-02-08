using System;

namespace CSharpBasics
{
    internal class InstructionsSaut
    {
        public static void InstructionsBreak()
        {
            Console.WriteLine("InstructionsBreak");

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }

                Console.WriteLine(i);
            }
        }

        public static void InstructionsContinue()
        {
            Console.WriteLine("InstructionsContinue");

            for (int i = 0; i < 10; i++)
            {
                if (i > 3 && i < 9)
                {
                    continue;
                }

                Console.WriteLine(i);
            }
        }

        public static void InstructionsBreakBoucleWhile()
        {
            Console.WriteLine("InstructionsBreakBoucleWhile");

            int i = 0;

            while (i < 8)
            {
                Console.WriteLine(i);
                i++;
                if (i == 4)
                {
                    break;
                }
            }
        }

        public static void InstructionsContinueBoucleWhile()
        {
            Console.WriteLine("InstructionsContinueBoucleWhile");

            int i = 0;

            while (i < 8)
            {
                if (i == 4)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(i);
                i++;
            }
        }

    }
}
