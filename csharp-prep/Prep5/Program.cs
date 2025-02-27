using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        String name = PromptUserName();
        int number = PromptUserNumber();
        int squaredNumber = SquareNumber(number);
        DisplayResult(squaredNumber, name);

    }

    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the Program!");
    }

    static String PromptUserName(){
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber(){
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());

    }

    static int SquareNumber(int x) {
        return x*x;
    }

    static void DisplayResult(int sqnumber, String name) {
        Console.WriteLine(name + ", the square of your number is " + sqnumber);
    }

}