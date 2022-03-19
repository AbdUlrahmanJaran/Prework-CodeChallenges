using System;

namespace Prework_CodeChallenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to My Game");
            // ArrayMaxResult();

            // Console.WriteLine("Enter a Year to check if it's a Leap Year");
            // String inputYear = Console.ReadLine();
            // int year = int.Parse(inputYear);
            // Console.WriteLine(LeapYearCalculator(year));

            // int[] array1 = {2,2};
            // int[] array2 = {1,3,2};
            // int[] array3 = {0,2,-2};
            // Console.WriteLine("[2,2] " + PerfectSequence(array1));
            // Console.WriteLine("[1,3,2] " + PerfectSequence(array2));
            // Console.WriteLine("[0,2,-2] " + PerfectSequence(array3));

            SumOfRows();
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

        static String LeapYearCalculator(int year)
        {
            Boolean leap= false;
            if (year % 4 == 0)
            {
                leap = true;
                if (year % 100 == 0)
                {
                    leap = false;
                    if (year % 400 == 0)
                    {
                        leap = true;
                    }
                }
            }
            if (leap)
                return "Yes It is";
            else
            return "No it's Not";
        }

        static String PerfectSequence(int [] array)
        {
            String sequence = "Yes";
            int sum = 0;
            int product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) sequence = "No";
            }
            if (sum != product) sequence = "No";
            return sequence;
        }

        static void SumOfRows()
        {
            Console.WriteLine("Enter the array length: ");
            String userInput1 = Console.ReadLine();
            int userInput1I = int.Parse(userInput1);
            Console.WriteLine("Enter the array width: ");
            String userInput2 = Console.ReadLine();
            int userInput2I = int.Parse(userInput2);

            int[,] myArray = new int[userInput1I, userInput2I];
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i,j] = 2;
                }
            }
            int sum1 = 0;
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    sum1 += myArray[i,j];
                }
            }
            int sum2 = 0;
            for (int i = 1; i < 2; i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    sum2 += myArray[i, j];
                }
            }
            int sum3 = 0;
            for (int i = 2; i < 3; i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    sum3 += myArray[i, j];
                }
            }
            int [] array = {sum1 ,sum2 ,sum3 };
            Console.Write("[ ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+ " ");
            }
            Console.Write("]");
        }
    }
}
