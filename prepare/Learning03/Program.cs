using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);

        List <Fraction> fractions = [fraction1, fraction2, fraction3];

        foreach (Fraction fraction in fractions){
            Console.Out.WriteLine(fraction.GetTop());
            Console.Out.WriteLine(fraction.GetBottom());
            Console.Out.WriteLine(fraction.GetFractionString());
            Console.Out.WriteLine(fraction.GetFractionDecimal());
            Console.Out.WriteLine();
            
            

        }
        fraction3.SetTop(3);
        fraction3.SetBottom(4);

        Console.Out.WriteLine(fraction3.GetTop());
        Console.Out.WriteLine(fraction3.GetBottom());
        Console.Out.WriteLine(fraction3.GetFractionString());
        Console.Out.WriteLine(fraction3.GetFractionDecimal());


    }
}