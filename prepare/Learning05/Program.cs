using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("green", 5);
        Console.Out.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle("blue", 6, 7);
        Console.Out.WriteLine(rectangle.GetArea());

        Circle circle = new Circle("pink", 8);
        Console.Out.WriteLine(circle.GetArea());
    }
}