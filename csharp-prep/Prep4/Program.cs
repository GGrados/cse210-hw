using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int newNumber = -1;

        do
        {

            Console.WriteLine("Enter a number");

            newNumber = Convert.ToInt32(Console.ReadLine());


            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }




        }

        while (newNumber != 0);

        int resultSum = 0;
        foreach (int number in numbers)
        {
            resultSum += number;
        }

        Console.WriteLine($"The sum is: {resultSum}");


        int arrayLen = numbers.Count;

        float numbersAverage = resultSum / arrayLen;


        Console.WriteLine($"The average is: {numbersAverage}");


        // Largest Number

        int largestNumber = 0;

        foreach (int number in numbers)
        {
            if (number > largestNumber)
            {

                largestNumber = number;
            }
        }


        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}