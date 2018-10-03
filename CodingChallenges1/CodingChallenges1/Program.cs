using System;

namespace CodingChallenges1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine($"Resulting Score:{SelectionScoring()}");
        }

        static int SelectionScoring()
        {
            int[] inputArray = new int[5];

            //Get numbers and display input to user
            Console.WriteLine("Please enter 5 numbers between 1-10, hitting enter after each number");
            int i = 0;
            while (i < 5)
            {
                inputArray[i]= Convert.ToInt32(Console.ReadLine());
                i++;
            }
            Console.Write("You entered the following numbers: ");
            for (i = 0; i < inputArray.Length; i++)
            {
                Console.Write(inputArray[i] + " ");
            }
            Console.WriteLine();

            //Get number from user
            Console.WriteLine("Please select a number from the list of entered numbers:");
            int num = Convert.ToInt32(Console.ReadLine());

            //Find occurrences of num in inputArray
            int count = 0;
            for (i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == num)
                    count++;
            }

            return (num * count);
        }
    }
}
