

using System.Globalization;
using System.Security.Cryptography;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Reflect : Activity {

    ReflectQuestions _reflectQuestions;

    public Reflect(){
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }


    public void MainProgram(){
        LoadQuestions();

        WelcomeMessage();

        DisplayPrompt();

        DisplayQuestions(_duration);

        CompletionMessage();
    }

    
    public void LoadQuestions(){
        string filePath = "reflect.json";

        if (File.Exists(filePath))
        {
            string jsonString = File.ReadAllText(filePath);
            ReflectQuestions reflectQuestions = JsonSerializer.Deserialize<ReflectQuestions>(jsonString);
            _reflectQuestions = reflectQuestions;
        }
        else
        {
            Console.WriteLine("File not found.");
            return;
        }
    }
    public void DisplayPrompt(){
        Random random = new Random();
        int length = _reflectQuestions.prompts.Length;
        int randomNumber = random.Next(0,length);
        Console.Out.Write(_reflectQuestions.prompts[randomNumber]);
        Spinner(5);
    }

    public void DisplayQuestions(int duration){
        duration = duration - 5; //accounts for thinking about the prompt
        Random random = new Random();
        int length = _reflectQuestions.questions.Length;
        int seconds = 0;
        List<string> usedQuestions = new List<string>{};
        int randomNumber;
        string question;
        int pause;
        int numberOfQuestions = duration / 5;
        pause = duration / numberOfQuestions;
        while (seconds < duration){
            randomNumber = random.Next(0,length);
            question = _reflectQuestions.questions[randomNumber];
            if(usedQuestions.Contains(question)){
                continue;
            }
            else{
                Console.Out.Write($">>{question}");
                usedQuestions.Add(question);
                seconds+=pause;
                Spinner(pause);
            }
        }
    }
    
}

public class ReflectQuestions {
    
    public string[] prompts {get; set;}
    public string[] questions {get; set;}

    public string[] GetPrompts(){
        return prompts;
    }
    public void SetPrompts(string[] _prompts){
        prompts = _prompts;
    }

    public string[] GetQuestions(){
        return questions;
    }
    public void SetQuestions(string[] _questions){
        questions = _questions;
    }

}