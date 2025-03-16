using System;
using System.IO.Pipes;

class Program
{
    static void Main(string[] args)
    {
        
        MainProgram();
    }


    // public void SaveGoals(List<Goal> goals){
    //     //save goals to csv


    // }

    public static void MainProgram(){
        string choice = "0";

        Console.Out.WriteLine("Please enter your name.");
        string name = Console.ReadLine();
        IndividualRecord user = new IndividualRecord(name);

        while (choice != "6"){
            
            DisplayMenu(user);
            choice = Console.ReadLine();
            switch (choice){

                case "1": 
                    user.AddGoal();
                    break;
                case "2":
                    user.ListGoals();
                    break;
                case "3":
                    Console.Out.WriteLine("Please enter a file name, .csv will be added");
                    string filePath = Console.ReadLine();
                    filePath = filePath + ".csv";
                    user.SaveGoals(filePath);
                    break;
                case "4":
                    Console.Out.WriteLine("Please enter the file name:");
                    filePath = Console.ReadLine();
                    user.LoadGoals(filePath);
                    break;
                case "5":
                    Console.Out.WriteLine("Please enter the number of the goal you would like to record an event for:");
                    user.ListGoals();
                    string stringChoice = Console.ReadLine();
                    bool checker = int.TryParse(stringChoice, out int selectedChoice);
                    if (checker && selectedChoice < user.GetGoals().Count+1){
                        selectedChoice -= 1;
                        List<Goal> goals = user.GetGoals();
                        user.AddPoints(goals[selectedChoice].Repetition());
                    }
                    else{
                        Console.Out.WriteLine("That was not a valid entry, please try again");
                    }
                    break;
                case "6":
                    Console.Out.WriteLine("Thank you!");
                    break;
                default:
                    Console.Out.WriteLine("That was not a valid entry, please try again.");
                    break;
            }
        }
    }

    public static void DisplayMenu(IndividualRecord record){
        record.DisplayPoints();
        Console.Out.WriteLine("\nMenu Options:");
        Console.Out.WriteLine("1. Create Goal \n2. List Goals \n3. Save Goals \n4. Load Goals \n5. Record Event \n6. Quit");
        Console.Out.WriteLine("Select a choice from the menu.");
        

    }

}