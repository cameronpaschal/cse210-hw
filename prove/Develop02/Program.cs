using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        int choice = 10;
        Journal journal = new Journal();
        do{
            bool validEntry = false;
            Console.Out.WriteLine("Please enter a number to select an option: \n 1. Write new entry \n 2. Display journal \n 3. Load journal from file \n 4. Save journal \n 5. Exit");
            while(!validEntry){
                string stringChoice = Console.ReadLine();
                if (int.TryParse(stringChoice, out int result)){
                choice = result;
                    if (choice <= 5 && choice > 0){
                        validEntry = true;
                    }
                    else{
                        Console.Out.WriteLine("That wasn't a valid entry");
                        Console.Out.WriteLine("Please enter a number between 1-5 to select an option: \n 1. Write new entry \n 2. Display journal \n 3. Load journal from file \n 4. Save journal \n 5. Exit");
                        validEntry = false;
                    }
                }
                else{
                    Console.Out.WriteLine("That wasn't a number");
                    Console.Out.WriteLine("Please enter a number to select an option: \n 1. Write new entry \n 2. Display journal \n 3. Load journal from file \n 4. Save journal \n 5. Exit");
                }
            }


            switch (choice){
                case 1: Entry entry = journal.NewEntry();
                journal._entries.Add(entry);
                break;

                case 2: journal.Display();
                break;

                case 3: Console.Out.WriteLine("Please enter a filename with the ending .txt");
                string loadFile = Console.ReadLine();
                journal.Load(loadFile);
                break;

                case 4: Console.Out.WriteLine("Please enter a filename with the ending .txt");
                string saveFile = Console.ReadLine();
                journal.Save(saveFile);
                break;

                case 5: Console.Out.WriteLine("Thank you! Goodbye");
                break;
            }

        }while (choice != 5);
    }

}