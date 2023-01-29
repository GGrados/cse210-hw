using System;
using System.IO;


public class PromptGenerator
{

    public List<String> _prompts = new List<String>(); //  Empty list of prompts




    Random randomGenerator = new Random();  // Random Object 

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


    public string PickRandomPrompt()
    {
        int randomNumber = randomGenerator.Next(0, _prompts.Count); //Creating random number to use as a index
        string prompt = _prompts[randomNumber]; // Selecting a random prompt from _prompts
        return prompt;
    }




    // I didn't use this method
    public void DisplayRandomPrompt()
    {

        Console.WriteLine(PickRandomPrompt());
    }


}
















