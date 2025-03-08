using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        
        bool end = false;

        while (end != true){
            end = DisplayMenu();
        }


    }


    public static bool DisplayMenu(){

        Breathe breathe = new Breathe();
        Reflect reflect = new Reflect();
        List list = new List();

        
        
        while(true){
        Console.Clear();
        Console.Out.WriteLine("Please select one of the following options");
        Console.Out.WriteLine("1. Breathing Activity \n2. Reflecting Activity \n3. Listing Activity \n4. Quit");
            string input = Console.ReadLine();
            switch(input) {
            case "1": 
                breathe.MainProgram();
                break;

            case "2": 
                reflect.MainProgram();
                break;
            case "3":
                list.MainProgram();
                break;
            case "4": 
                return true;

            default: 
                Console.Out.WriteLine("Please enter a number 1-4"); 
                break;
        }
        
        }

    }
}


public class Vehicle{
    public int _tires;
    public string _type;

    public void MoveForward(){
        Console.Out.WriteLine($"the {_type} moves forward");
    }
}

public class Car : Vehicle{

    public Car(){
        _tires = 4;
        _type = "Car";
    }
}