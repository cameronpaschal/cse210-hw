using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("green", 5);
        Console.Out.WriteLine(square.GetArea());
    }
}