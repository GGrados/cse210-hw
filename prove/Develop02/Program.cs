using System;
using System.IO;


class Program
{
    static void Main(string[] args)
    {



        Journal journal = new Journal(); // Journal Object
        PromptGenerator promptGenerator = new PromptGenerator(); // PromptGenerator object


        promptGenerator.CreatePromts(); // Add the prompts to the _prompts list from PromptGenerator Class


        bool runProgram = true; // Program starts
        while (runProgram) // Program starts 
        {

            Console.WriteLine("Please select one of the following choices:  ");
            Console.WriteLine("1- Write");
            Console.WriteLine("2- Display");
            Console.WriteLine("3- Load");
            Console.WriteLine("4- Save");
            Console.WriteLine("5- Quit");
            int userChoice = Convert.ToInt32(Console.ReadLine()); // Parsing the input to int


            string randomPrompt = promptGenerator.PickRandomPrompt(); // Selecting a random prompt an saving it into a variable


            // Write
            if (userChoice == 1)
            {
                Console.WriteLine(randomPrompt); // Printing the random Prompt
                string userEntry = Console.ReadLine();

                journal.AddingEntry(randomPrompt, userEntry); //Method from the Journal Class
            }


            // Display
            if (userChoice == 2)
            {
                journal.DisplayEntries(); // Method from the Journal Class
            }


            // Load
            if (userChoice == 3)
            {
                journal.LoadFromFile(); // Method from the Journal Class
            }

            // Save
            if (userChoice == 4)
            {
                journal.SaveToFile(); // Method from the Journal Class
            }

            if (userChoice == 5)
            {
                runProgram = false;
            }
        }
    }
}
