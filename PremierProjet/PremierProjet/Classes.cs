namespace CSharpClasses
{
    internal class Classes
    {
    }

    public class Calculator
    {
        public static int Add(bool execute, params int[] numbers)
        {
            int somme = 0;

            if (execute)
            {
                foreach (var number in numbers)
                {
                    somme += number;
                }
            }

            return somme;
        }
    } 
}
