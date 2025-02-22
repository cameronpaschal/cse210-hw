using System;
using System.IO;
using System.Linq;


public class PromptGenerator
{

    public String GenerateNewPrompt(){

        string filePath = "prompts.txt";

        int lineCount = File.ReadLines(filePath).Count();

        // Console.WriteLine($"Total lines: {lineCount}");

        int min = 1;

        Random random = new Random();

        int randomNumber = random.Next(min, lineCount + 1); // Generates a number between min and max (inclusive)

        Console.WriteLine($"You are using prompt: {randomNumber}\n");

        string prompt = File.ReadLines(filePath).Skip(randomNumber - 1).FirstOrDefault();
        
        return prompt;

    }

}