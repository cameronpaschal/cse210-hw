using System;
using System.Data;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("verse.txt");
        bool status = false;
        bool exitLoop = false;

        Console.Out.WriteLine("Please press enter to remove more words when ready. Press Esc to exit.");
        scripture.Display();
        while (true){
            ConsoleKeyInfo key = Console.ReadKey(intercept: true);
            
            if (key.Key == ConsoleKey.Enter){
                status = scripture.EraseWord();
                Console.Clear();
                scripture.Display();
            }
            else if (key.Key == ConsoleKey.Escape){
                Console.Out.WriteLine("Thank you!");
                break;

            }
            else {
                Console.Out.WriteLine("Invalid key please press enter to clear more words or esc to quit.");
            }

            while (status == true){

                if (status == true){
                    Console.Out.WriteLine("Congratulations!\nWould you like to start over? \n(Y/N)");
                    ConsoleKeyInfo key2 = Console.ReadKey(intercept: true);
                    if (key2.Key == ConsoleKey.Y){
                        scripture.UnhideAllWords();
                        status = false;
                        Console.Clear();
                        scripture.Display();
                    }
                    else if (key2.Key == ConsoleKey.N){
                        Console.Out.WriteLine("Thank you!");
                        exitLoop = true;
                        break;
                        
                    }
                    else{
                        Console.Out.WriteLine("Please press Y or N");
                    }
                }
            }
            if (exitLoop){
                break;
            }

        }
        
    }
}