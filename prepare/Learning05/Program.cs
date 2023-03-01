using System;

class Program
{
    static void Main(string[] args)
    {

        Square square = new Square("Yellow", 6);
        Rectangle rectangle = new Rectangle("Blue", 10, 7);
        Circle circle = new Circle("Green", 8.5);


        List<Shape> shapes = new List<Shape>();

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }


    }
}