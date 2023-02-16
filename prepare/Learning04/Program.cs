using System;

class Program
{
    static void Main(string[] args)
    {

        Assignment assignment = new Assignment("Cesar", "Classes");

        string summary = assignment.GetSummary();
        Console.WriteLine(summary);


        MathAssignment math = new MathAssignment("Cesar", "Classes", "two", "one");

        math.GetHomeworkList();



    }
}