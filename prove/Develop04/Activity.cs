using System;

public class activity
{

    protected string _startMessage = "Welcome to ";

    protected List<string> _animation = new List<string>();

    protected List<string> _prompts = new List<string>();
    protected List<string> _questions = new List<string>();


    public void IntroductionAndTime(string activityName, string description)
    {

        Console.Clear();
        Console.WriteLine(_startMessage + activityName);
        Console.WriteLine();
        Console.WriteLine(description);
        Console.WriteLine();



    }


    public void Menu()
    {
        Console.Clear();

        Console.WriteLine("Menu Options: ");
        Console.WriteLine("     1. Start Breathing  activity");
        Console.WriteLine("     2. Start Reflecting activity");
        Console.WriteLine("     3. Start listing activity");
        Console.WriteLine("     4. Quit");
        Console.Write("Select a choice from the menu: ");

    }
    public void Animation(int seconds)
    {

        _animation.Add("|");
        _animation.Add("/");
        _animation.Add("-");
        _animation.Add("\\");
        _animation.Add("|");
        _animation.Add("|");
        _animation.Add("/");
        _animation.Add("-");
        _animation.Add("\\");


        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = _animation[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;

            if (i >= _animation.Count)
            {
                i = 0;
            }
        }
    }
    public void GetReady(int seconds)
    {
        Console.Clear();
        Console.Write("Get Ready...");
        Animation(seconds);
        Console.WriteLine();
    }


    public int HowLong()
    {
        Console.Write("How long, in seconds, would you like for your session: ");
        int howLongTime = Convert.ToInt32(Console.ReadLine());
        return howLongTime;
    }


    public bool VerifyTime(int timer, DateTime futuretime)
    {

        if (DateTime.Now < futuretime)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    protected string SelectRandomItem(List<string> list)
    {

        Random randomGenerator = new Random();

        int randomprompt = randomGenerator.Next(0, list.Count);
        string prompt = list[randomprompt];
        return prompt;
    }


    public void CountDown(int seconds)
    {
        for (int i = seconds; i >= 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void FinishMessage(int seconds, string activity)
    {
        Console.WriteLine();
        Console.WriteLine("well Done");
        Console.WriteLine();
        Console.WriteLine($"You have completed {seconds} seconds of the {activity}");
        Animation(6);

    }



}


