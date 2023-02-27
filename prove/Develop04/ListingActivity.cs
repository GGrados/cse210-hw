using System;

using System;

public class ListingActivity : activity
{


    private string _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    private string _activityName = "Listing Activity";

    private List<string> _userResponses = new List<string>();





    public ListingActivity()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Enlist(int timer)
    {
        ShowPrompt();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(timer);
        while (VerifyTime(timer, futureTime))
        {
            _userResponses.Add(UserResponses());
        }
        Console.WriteLine($"You listed {_userResponses.Count} items");


    }


    public void ShowPrompt()
    {
        GetReady(2);
        Console.WriteLine("List as many responses you can to the following prompt:");
        string randomPrompt = SelectRandomItem(_prompts);
        Console.WriteLine($"---- {randomPrompt} ----");
        Console.Write("You may beggin in: ");
        CountDown(5);
        Console.WriteLine();


    }


    public string UserResponses()
    {
        Console.Write("> ");
        string answer = Console.ReadLine();
        return answer;
    }
    public string GetActivityName()
    {
        return _activityName;
    }
    public string GetDescription()
    {
        return _description;
    }

}