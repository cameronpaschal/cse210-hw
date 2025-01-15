using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers and type 0 when finished");
        int newNumber;
        List<int> numbers = new List<int>();

        do {
            Console.Write("Enter a number: ");
            newNumber = int.Parse(Console.ReadLine());
            numbers.Add(newNumber);
        }
        while (newNumber != 0);

        int sum = 0;
        int max = 0;


        foreach (int number in numbers) {
            sum = sum + number;
            max = Math.Max(max, number);

        }
        double average = sum / numbers.Count;
        Console.WriteLine("The sum is " + sum);
        Console.WriteLine("The average is " + average);
        Console.WriteLine("The highest number is "+ max);



    }
}