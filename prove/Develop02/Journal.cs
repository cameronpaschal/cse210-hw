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

    string filePath = $"{filename}";

    if (!File.Exists(filePath)){
        Console.Out.WriteLine("File could not be found!");
        return;
    }

    string[] lines = File.ReadAllLines(filePath);

    int x = 0;

    while (x < lines.Length){
        Entry entry = new Entry();
        entry._dateTime = lines[x];
        x++;
        entry._prompt = lines[x];
        x++;
        entry._entry = lines[x];
        x++;
        _entries.Add(entry);
    }
}

public void Save(string filename){

    string filePath = $"{filename}";

    if (!File.Exists(filePath)){
        File.Create(filePath).Close();
    }

    StreamWriter writer = new StreamWriter(filePath, append: true);
    
    foreach(Entry entry in _entries){
        writer.WriteLine(entry._dateTime);
        writer.WriteLine(entry._prompt);
        writer.WriteLine(entry._entry);
    }
    writer.Close();

}

public Entry NewEntry(){
    PromptGenerator pG = new PromptGenerator();
    Entry entry = new Entry();

    DateTime theCurrentTime = DateTime.Now;
    entry._dateTime = theCurrentTime.ToLongDateString();
    entry._prompt = pG.GenerateNewPrompt();

    Console.Out.WriteLine(entry._dateTime);
    Console.Out.WriteLine(entry._prompt);
    entry._entry = Console.ReadLine();

    return entry;

}

}