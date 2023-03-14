using System;


public class EternalGoal : Goal
{



    public override void AskForInfo()
    {


        Console.Write("Goal Name: ");
        _goalName = Console.ReadLine();

        Console.Write("Goal Description: ");
        _goalDescription = Console.ReadLine();

        Console.Write("How many points you will win every time you do this activity: ");
        _pointsForEachTIme = Convert.ToInt32(Console.ReadLine());


    }


    public override string GetStringRepresentation()
    {
        return ($"{_goalType}, {_goalName}, {_goalDescription}, {_pointsForEachTIme}");

    }

}