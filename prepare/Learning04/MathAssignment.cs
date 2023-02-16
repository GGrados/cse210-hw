using System;


public class MathAssignment : Assignment
{

    private string _texbookSection;
    private string _problems;


    public MathAssignment(string name, string topic, string texbookSection, string problems) : base(name, topic)
    {

        _texbookSection = texbookSection;
        _problems = problems;
    }

    public void GetHomeworkList()
    {
        Console.WriteLine(_problems);
    }


}