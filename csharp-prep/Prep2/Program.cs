using System;

class Program
{
    static void Main(string[] args)
    {


        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 100);

        int userGuesses = 0;
        int userNumber;

        do
        {

            userGuesses += 1;
            Console.WriteLine("What is your guess?: ");
            userNumber = Convert.ToInt32(Console.ReadLine());

            if (userNumber < randomNumber) Console.WriteLine("Lower");

            if (userNumber > randomNumber) Console.WriteLine("Higher");



        } while (userNumber != randomNumber);



        Console.WriteLine("You guessed it!");
        Console.WriteLine($"Your tried to guess{Convert.ToString(userGuesses)} times");



    }
}



//Console.WriteLine($"Your name is {last}, {first} {last}.");
