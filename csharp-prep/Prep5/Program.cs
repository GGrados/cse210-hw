using System;

class Program
{
    static void Main(string[] args)
    {

        static void DisplayWelcome()
        {

            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {

            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {

            Console.WriteLine("Please enter your favorite number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        static int SquareNumber(int number)
        {

            return number * number;
        }

        static void DisplayResult(int squareNumber, string name)
        {


            Console.WriteLine($"{name}, the square of your number is {squareNumber}");

        }




        DisplayWelcome();

        string userName = PromptUserName();
        int userFavoriteNumber = PromptUserNumber();

        DisplayResult(SquareNumber(userFavoriteNumber), userName);


    }
}