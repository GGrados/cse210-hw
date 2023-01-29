public class Journal
{
    //Attribute
    // _Prompts holds all the possible questions
    public List<String> _prompts = new List<String>(); //  holds all the possible questions



    public void CreatePromts() // this method add the prompts to the list
    {
        string prompt1 = "Who was the most interesting person I interacted with today?";
        string prompt2 = "What was the best part of my day?";
        string prompt3 = "How did I see the hand of the Lord in my life today?";
        string prompt4 = "What was the strongest emotion I felt today?";
        string prompt5 = "If I had one thing I could do over today, what would it be?";
        _prompts.Add(prompt1);
        _prompts.Add(prompt2);
        _prompts.Add(prompt3);
        _prompts.Add(prompt4);
        _prompts.Add(prompt5);
    }


    public void Prompt(int randomNumber, string currentDate, FileManager fileManager) // Show the prompt and save the answer
    {

        string prompt = _prompts[randomNumber]; // Selecting a random question from _prompts
        Console.WriteLine(prompt);
        string answer = Console.ReadLine();

        fileManager.WriteFile(currentDate, prompt, answer); // Using a method from the FileManager Class
    }


    public void DisplayRecords(string filename) // Readign the file to print the records
    {

        string[] lines = System.IO.File.ReadAllLines(filename); // List of lines

        foreach (string line in lines) // looping the lines
        {

            Console.WriteLine(line); // printing the current line 

        }

    }

}
