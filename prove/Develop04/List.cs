

using System.Diagnostics;
using System.Text.Json;

public class List : Activity {

    ListPrompts _listPrompts;


    public List(){
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void MainProgram(){
        LoadPrompts();

        WelcomeMessage();

        DisplayPrompt();

        Responses(_duration);

        CompletionMessage();
    }


    public void Responses(int duration){
        duration = duration - 5;
        int enterCount = 0;
        double elapsedTime = 0;
        TimeSpan time;
        Console.WriteLine($"You have {duration} seconds left. Please list as many answers as you can. Press enter after each one.");
        Stopwatch stopwatch = new Stopwatch();
        while (elapsedTime < duration) {
            stopwatch.Start();
            string input = Console.ReadLine();
            enterCount++;
            stopwatch.Stop();
            time = stopwatch.Elapsed;
            elapsedTime = time.Seconds;
        }
        Console.Out.WriteLine($"You listed {enterCount} items!");


    }

    public void DisplayPrompt(){
        Random random = new Random();
        int length = _listPrompts.prompts.Length;
        int randomNumber = random.Next(0,length);
        Console.Out.Write($"{_listPrompts.prompts[randomNumber]} ");
        DisplayTime(5);
    }

    public void LoadPrompts(){
        string filePath = "list.json";

        if (File.Exists(filePath))
        {
            string jsonString = File.ReadAllText(filePath);
            ListPrompts listPrompts = JsonSerializer.Deserialize<ListPrompts>(jsonString);
            _listPrompts = listPrompts;
        }
        else
        {
            Console.WriteLine("File not found.");
            return;
        }
    }
    
}

public class ListPrompts{
    public string[] prompts {get; set;}

    public string[] GetPrompts(){
        return prompts;
    }
    public void SetPrompts(string[] _prompts){
        prompts = _prompts;
    }
}