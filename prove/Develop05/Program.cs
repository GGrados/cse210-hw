using System;

class Program
{
    static void Main(string[] args)
    {

        Manager manager = new Manager();




        bool runProgram = true;
        while (runProgram)
        {
            manager.ShowMainMenu();
            int userChoice = Convert.ToInt32(Console.ReadLine());

            if (userChoice == 1)
            {

                int goalType = manager.SelectTypeOfGoal();

                if (goalType == 1)
                {
                    SimpleGoal simpleGoal = new SimpleGoal();
                    simpleGoal.SetGoalType("Simple Goal");
                    simpleGoal.AskForInfo();
                    manager.AddOGoalbject(simpleGoal);
                }

                else if (goalType == 2)
                {
                    EternalGoal eternalGoal = new EternalGoal();
                    eternalGoal.SetGoalType("Eternal Goal");
                    eternalGoal.AskForInfo();
                    manager.AddOGoalbject(eternalGoal);
                }

                else if (goalType == 3)
                {
                    CheckListGoal checkListGoal = new CheckListGoal();
                    checkListGoal.SetGoalType("Checklist Goal");
                    checkListGoal.AskForInfo();
                    manager.AddOGoalbject(checkListGoal);
                }

            }

            else if (userChoice == 2)
            {
                manager.ShowListOfGoals();
            }


            else if (userChoice == 3)
            {
                manager.SaveGoals();
            }


            else if (userChoice == 4)
            {
                manager.LoadGoals();
            }


            else if (userChoice == 5)
            {
                Console.Clear();
                int counter = 1;
                foreach (Goal goal in manager._goalsObjects)
                {

                    Console.WriteLine($"{counter}- {goal._goalName}");
                    counter++;
                }

                Console.WriteLine();
                Console.WriteLine("Which goal would you like to record?: ");
                int goalToRecord = Convert.ToInt32(Console.ReadLine()) - 1;


                if (manager._goalsObjects[goalToRecord]._goalType == "Simple Goal")
                {
                    manager._goalsObjects[goalToRecord]._isCompleted = "True";
                    manager._totalPoints += manager._goalsObjects[goalToRecord]._goalPoints;


                }

                else if (manager._goalsObjects[goalToRecord]._goalType == "Eternal Goal")
                {
                    manager._goalsObjects[goalToRecord]._accumulatedPoints += manager._goalsObjects[goalToRecord]._pointsForEachTIme;
                    manager._totalPoints += manager._goalsObjects[goalToRecord]._accumulatedPoints;
                }

                else if (manager._goalsObjects[goalToRecord]._goalType == "Checklist Goal")
                {
                    if (manager._goalsObjects[goalToRecord]._timesCompleted != manager._goalsObjects[goalToRecord]._timesToComplete)
                    {
                        manager._goalsObjects[goalToRecord]._timesCompleted += 1;
                        manager._goalsObjects[goalToRecord]._accumulatedPoints += manager._goalsObjects[goalToRecord]._pointsForEachTIme;
                        manager._totalPoints += manager._goalsObjects[goalToRecord]._accumulatedPoints;
                    }

                    else
                    {
                        manager._goalsObjects[goalToRecord]._accumulatedPoints += manager._goalsObjects[goalToRecord]._goalPoints;
                        manager._totalPoints += manager._goalsObjects[goalToRecord]._goalPoints;

                        Console.WriteLine("You have completed this goal!");
                    }



                }


            }

        }
    }
}