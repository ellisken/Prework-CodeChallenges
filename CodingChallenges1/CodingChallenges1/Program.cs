using System;

namespace CodingChallenges1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"Resulting Score:{SelectionScoring()}");
            //Console.WriteLine($"Year is leap year? {LeapYear()}");
            int[] testArray1 = {4, 5, 6};
            int[] testArray2 = { 1, 3, 2 };
            //Console.WriteLine($"{String.Join(" ", testArray1)} Perfect Sequence? {PerfectSequence(testArray1)}");
            //Console.WriteLine($"{String.Join(" ", testArray2)} Perfect Sequence? {PerfectSequence(testArray2)}");
        }

        // Challenge 1 solution
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

        //Challenge 2 solution
        static bool LeapYear()
        {
            Console.WriteLine("Please enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0 && year % 400 == 0)
            {
               return true;
            }
            else if(year % 4 == 0 && year % 100 != 0)
                return true;
            else return false;
        }

        //Challenge 3 solution
        static string PerfectSequence(int[] nums)
        {
            int sum = 0;
            int product = 1;
            bool noNegatives = true;

            foreach (int num in nums)
            {
                //If num is negative, break and set flag
                if (num < 0)
                {
                    noNegatives = false;
                    break;
                }
                //Else update product and sum
                sum += num;
                product *= num;
            }
            // Check for perfect 
            if (sum == product && noNegatives)
                return "Yes";

            return "No";
        }
    }
}
