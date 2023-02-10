using System;

class Program
{
    static void Main(string[] args)
    {

        // Default scripture reference
        String book = "Mosiah";
        String chapter = "2";
        String verse = "22";
        String secondVerse = "23"; // not using this yet, just in case a end verse is needed


        // Reference Object
        Reference reference = new Reference(book, chapter, verse, secondVerse); // Using the constructor with 3 arguments from the Reference Class
        // Scripture Object
        Scripture scripture = new Scripture();


        // setting the reference as an attribure in the Scripture class
        scripture._reference = reference.GetReference();


        Console.WriteLine("Press enter to continue o press 'quit' to quit");
        Console.ReadLine();



        while (scripture.IsCompletelyHidden())
        {

            scripture.GetRenderedText(); // Print the scripture
            Console.ReadLine(); // Waiting for enter key
            Console.Clear(); // Clear Console 
            scripture.HideWords(8); // Hide Words, the argument is the amount of words to hide

        }

    }


}