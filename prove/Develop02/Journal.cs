using System;
using System.IO;


public class Journal
{


public List <Entry> _entries = new List<Entry>();

public void Display(){
    foreach (Entry entry in _entries){
        entry.Display();
        Console.Out.WriteLine();
    }
}

public void Load(string filename){

    string filePath = $"/Users/cameronpaschal/byui/semester-3/CSE210/cse210-hw/prove/Develop02/{filename}";

    if (!File.Exists(filePath)){
        Console.Out.WriteLine("File could not be found!");
        return;
    }

    string[] lines = File.ReadAllLines(filePath);

    int x = 0;

    while (x < lines.Length){
        Entry entry = new Entry();
        entry._DateTime = lines[x];
        x++;
        entry._Prompt = lines[x];
        x++;
        entry._Entry = lines[x];
        x++;
        _entries.Add(entry);
    }
}

public void Save(string filename){

    string filePath = $"/Users/cameronpaschal/byui/semester-3/CSE210/cse210-hw/prove/Develop02/{filename}";

    if (!File.Exists(filePath)){
        File.Create(filePath).Close();
    }

    StreamWriter writer = new StreamWriter(filePath, append: true);
    
    foreach(Entry entry in _entries){
        writer.WriteLine(entry._DateTime);
        writer.WriteLine(entry._Prompt);
        writer.WriteLine(entry._Entry);
    }
    writer.Close();

}

public Entry NewEntry(){
    PromptGenerator pG = new PromptGenerator();
    Entry entry = new Entry();

    DateTime theCurrentTime = DateTime.Now;
    entry._DateTime = theCurrentTime.ToLongDateString();
    entry._Prompt = pG.GenerateNewPrompt();

    Console.Out.WriteLine(entry._DateTime);
    Console.Out.WriteLine(entry._Prompt);
    entry._Entry = Console.ReadLine();

    return entry;

}

}