using System;

public class Goal
{

    // poner esto en un getter
    public string _goalName;
    public string _goalDescription;
    public int _goalPoints; // lo puntos que te daran cuando completes

    public int _accumulatedPoints = 0;
    public string _goalType;


    // Just for check list goals

    public int _timesToComplete;
    public int _pointsForEachTIme;

    public int _timesCompleted = 0;

    public string _isCompleted = "false";







    public virtual void AskForInfo()
    {
        Console.Write("Goal Name: ");
        _goalName = Console.ReadLine();

        Console.Write("Goal Description: ");
        _goalDescription = Console.ReadLine();

        Console.Write("How many points you will win once you finished this goal: ");
        _goalPoints = Convert.ToInt32(Console.ReadLine());



    }


    public virtual string GetStringRepresentation()
    {
        return ($"{_goalType}, {_goalName}, {_goalDescription}, {_goalPoints}, {_isCompleted}");
    }


    // Setters 


    public void SetGoalDescription(string description)
    {
        _goalDescription = description;
    }
    public void SetGoalType(string goalType)
    {
        _goalType = goalType;
    }

    public void SetGoalName(string goalName)
    {
        _goalName = goalName;
    }

    public void SetGoalPoints(int goalPoints)
    {
        _goalPoints = goalPoints;
    }

    public void SetisCompleted(string isCompleted)
    {
        _isCompleted = isCompleted;
    }

    public void SetPointsForEachTIme(int pointsForEachTIme)
    {
        _pointsForEachTIme = pointsForEachTIme;
    }

    public void SetTimesToComplete(int SetTimesToComplete)
    {
        _timesToComplete = SetTimesToComplete;
    }

    public void SetTimesCompleted(int timesCompleted)
    {
        _timesCompleted = timesCompleted;
    }





}