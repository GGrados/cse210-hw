using System;

class Program
{


    static void Main(string[] args)
    {

        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6); // top
        Fraction f3 = new Fraction(10, 2); //top and bottom

        //get top and bottom

        int top = f3.GetTop();
        int bottom = f3.GetBottom();
        Console.WriteLine(top);
        Console.WriteLine(bottom);
        Console.WriteLine();


        // Get fractions 

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());








    }
}