using System;


public class CheckListGoal : Goal
{



    public override void AskForInfo()
    {



        Console.Write("What is the name of the goal: ");
        _goalName = Console.ReadLine();

        Console.Write("What is a short description: ");
        _goalDescription = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal: "); // points each time I completed the goal
        _pointsForEachTIme = Convert.ToInt32(Console.ReadLine());

        Console.Write("How many times does this goal needs to be accomplished for a bonus?: ");
        _timesToComplete = Convert.ToInt32(Console.ReadLine());

        Console.Write("What is the bonus for accomplishing it that many times?: ");
        _goalPoints = Convert.ToInt32(Console.ReadLine());


    }

    public override string GetStringRepresentation()
    {
        return ($"{_goalName}, {_goalDescription}, {_goalPoints}, {_pointsForEachTIme}, {_timesToComplete}, {_goalPoints}");

    }



    public int gettime()
    {
        return _timesCompleted;
    }
}