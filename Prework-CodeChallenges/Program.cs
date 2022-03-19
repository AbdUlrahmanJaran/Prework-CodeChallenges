using System;

namespace Prework_CodeChallenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to My Game");
            ArrayMaxResult();
        }

        static void ArrayMaxResult()
        {
            int [] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter a Number between 1-10: "+ (i+1));
                String userInput1 = Console.ReadLine();
                int userInput1I = int.Parse(userInput1);
                array[i] = userInput1I;
            }
            Console.WriteLine();
            Console.Write("Pick a number from: [");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i != array.Length - 1) Console.Write(",");
                if (i == array.Length - 1) Console.Write("]");
            }
            Console.WriteLine();            
            String userInput2 = Console.ReadLine();
            int userInput2I = int.Parse(userInput2);
            Console.WriteLine();
            Score(array, userInput2I);
        }

        static void Score(int [] array , int userInput2I)
        {
            int score = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == userInput2I) score += userInput2I;
            }
            Console.WriteLine("Score : " + score);
        }
    }
}
