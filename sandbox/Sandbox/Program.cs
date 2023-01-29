using System;

class Program
{
    static void Main(string[] args)
    {


        Random randomGenerator = new Random();  // Rnadom Object
        DateTime theCurrentTime = DateTime.Now; // Date Objec
        Journal journal = new Journal(); // Journal Object
        FileManager fileManager = new FileManager();

        journal.CreatePromts(); // Creating the prompts

        bool runProgram = true; // Program starts
        while (runProgram) // Program starts 
        {

            Console.WriteLine("Please select one of the following choices: "); // First interaction
            Console.WriteLine("1- Write");
            Console.WriteLine("2- Display");
            Console.WriteLine("3- Load");
            Console.WriteLine("4- Save");
            Console.WriteLine("5- Quit");

            int userChoice = Convert.ToInt32(Console.ReadLine()); // Parsing the input to int


            if (userChoice == 1)
            {
                int randomNumber = randomGenerator.Next(0, journal._prompts.Count); //Creating random number to use as a index

                string dateText = theCurrentTime.ToShortDateString(); // getting the date as a string

                journal.Prompt(randomNumber, dateText, fileManager); // asking and saving the user's answer

            }

            if (userChoice == 2)
            {
                journal.DisplayRecords(fileManager._filename);// Printing the records of the current and open file 
            }

            if (userChoice == 3)
            {


                Console.WriteLine("Name of the file to load: "); // Load a file to write in it or display its content
                string filename = Console.ReadLine();
                fileManager._filename = filename; // Updating the attribute in a FileManager Class
            }


            if (userChoice == 4)
            {
                Console.WriteLine("Name of the new file: "); // saving file
                string newFileName = Console.ReadLine();
                fileManager.SaveFile(newFileName); // saving with a method from the FileManager Class

            }



        }
    }
}