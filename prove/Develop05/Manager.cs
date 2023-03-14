using System;
using System.Collections.Generic;
using System.Reflection;



public class Manager
{

    public List<Goal> _goalsObjects = new List<Goal>();

    public int _totalPoints = 0;

    public void GetTotalPoints()
    {

        if (_goalsObjects.Count == 0)
        {
            _totalPoints = 0;
        }
        else
        {

            foreach (Goal goal in _goalsObjects)
            {

                _totalPoints = +goal._accumulatedPoints;
            }

        }

    }




    public void ShowListOfGoals() //2
    {

        if (_goalsObjects.Count != 0)
        {

            int counter = 1;
            foreach (Goal goal in _goalsObjects)
            {
                if ((goal._goalType == "Simple Goal") || (goal._goalType == "Eternal Goal"))
                {

                    if (goal._isCompleted == "false")
                    {
                        Console.WriteLine($"{counter}. [ ] {goal._goalName} ({goal._goalDescription})");
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine($"{counter}. [X] {goal._goalName} ({goal._goalDescription})");
                        counter++;
                    }

                }
                else if (goal._goalType == "Checklist Goal")
                {
                    if (goal._isCompleted == "false")
                    {
                        Console.WriteLine($"{counter}. [ ] {goal._goalName} ({goal._goalDescription}) --- Currently Completed {goal._timesCompleted}/{goal._timesToComplete}");
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine($"{counter}. [x] {goal._goalName} ({goal._goalDescription}) --- Currently Completed {goal._timesCompleted}/{goal._timesToComplete}");
                        counter++;
                    }

                }
            }

        }
        else
        {
            Console.WriteLine("You haven't record any goal yet!...");
            Thread.Sleep(3000);
        }

        Console.WriteLine("Wait...");
        Thread.Sleep(3000);
    }
    public void ShowMainMenu()
    {



        Console.Clear();

        Console.Write($"You have {_totalPoints} points");
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("     1. Create New Goal");
        Console.WriteLine("     2. List Goals");
        Console.WriteLine("     3. Save Goals");
        Console.WriteLine("     4. Load Goals");
        Console.WriteLine("     5. Record Event");
        Console.WriteLine("     6. Quit");
        Console.Write("Select a choice from the menu: ");
    }


    public int SelectTypeOfGoal()
    {
        Console.Clear();
        Console.WriteLine("The Types of goals are:");
        Console.WriteLine("     1. Simple Goal");
        Console.WriteLine("     2. Eternal Goal");
        Console.WriteLine("     3. Check List Goal");
        Console.Write("Which type of goal do you like to create: ");
        int userChoice = Convert.ToInt32(Console.ReadLine());
        return userChoice;

    }







    public void AddOGoalbject(Goal goal)
    {
        _goalsObjects.Add(goal);

    }



    public void SaveGoals()
    {

        Console.WriteLine("What would you like to name the file? ");
        string filename = Console.ReadLine();
        using (StreamWriter textfile = new StreamWriter(filename, true))
        {
            foreach (Goal goal in _goalsObjects)
            {
                string stringRepresentation = goal.GetStringRepresentation();
                textfile.WriteLine(stringRepresentation);

            }
            textfile.Flush();


        }
    }



    public void LoadGoals()
    {

        _goalsObjects.Clear();


        GetTotalPoints();

        Console.WriteLine("What is the name of the file?: ");
        string filename = Console.ReadLine();


        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {

            string[] charParts = line.Split(",");


            //($"{_goalType}, {_goalName}, {_goalDescription}, {_goalPoints}, {_isCompleted}");
            if (Convert.ToString(line[0]) == "Simple Goal")
            {

                SimpleGoal simpleGoal = new SimpleGoal();


                simpleGoal.SetGoalType(Convert.ToString(line[0]));
                simpleGoal.SetGoalName(Convert.ToString(line[1]));
                simpleGoal.SetGoalDescription(Convert.ToString(line[2]));
                simpleGoal.SetGoalPoints(Convert.ToInt32(line[3]));
                simpleGoal.SetisCompleted(Convert.ToString(line[4]));

                _goalsObjects.Add(simpleGoal);
            }

            //($"{_goalType}, {_goalName}, {_goalDescription}, {_goalPoints}, {_isCompleted}");
            else if (Convert.ToString(line[0]) == "Eternal Goal")
            {


                EternalGoal eternalGoal = new EternalGoal();

                eternalGoal.SetGoalType(Convert.ToString(line[0]));
                eternalGoal.SetGoalName(Convert.ToString(line[1]));
                eternalGoal.SetGoalDescription(Convert.ToString(line[2]));
                eternalGoal.SetPointsForEachTIme(Convert.ToInt32(line[3]));

                _goalsObjects.Add(eternalGoal);

            }

            else //($"{_goalType}, {_goalName}, {_goalDescription}, {_goalPoints}, {_isCompleted}")  (",{_PointsForEachTIme}, {_TimesToComplete}, {_TimesCompleted}");
            {

                CheckListGoal checkListGoal = new CheckListGoal();

                checkListGoal.SetGoalType(Convert.ToString(line[0]));
                checkListGoal.SetGoalName(Convert.ToString(line[1]));
                checkListGoal.SetGoalDescription(Convert.ToString(line[2]));
                checkListGoal.SetGoalPoints(Convert.ToInt32(line[3]));
                checkListGoal.SetisCompleted(Convert.ToString(line[4]));
                checkListGoal.SetPointsForEachTIme(Convert.ToInt32(line[5]));
                checkListGoal.SetTimesToComplete(Convert.ToInt32(line[6]));
                checkListGoal.SetTimesCompleted(Convert.ToInt32((line[7])));

                _goalsObjects.Add(checkListGoal);

            }

        }

    }

}