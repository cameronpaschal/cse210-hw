using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

public class Scripture {

    private List<Word> _words = new List<Word>();
    private int counter = 0;
    private Reference _reference = new Reference();


    public Scripture(string filePath) {

        string[] rawReference = SplitWords(File.ReadLines(filePath).Skip(0).FirstOrDefault());
        string[] rawVerse = SplitWords(File.ReadLines(filePath).Skip(1).FirstOrDefault());

        foreach (string word in rawVerse) {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }

        _reference.SetBook(rawReference[0]);
        _reference.SetChapter(int.Parse(rawReference[1]));
        _reference.SetVerse(rawReference[2]);
    }

    public string[] SplitWords(string input){
        return Regex.Split(input, @"[\s,;:]+");
    }

    public void Display(){
        _reference.Display();
        foreach (Word word in _words) {
            word.Display();
        }
        Console.Out.WriteLine($"\nWords hidden: {counter}");
        Console.Out.WriteLine();
    }

    public bool EraseWord(){

        for(int x = 0; x<=3; x++){
            Random random = new Random();
            bool status = true;
            int length = _words.Count;
            int wordToChange = 0; 
            
            while(status == true) {
                int randomNumber = random.Next(0,length);
                status = _words[randomNumber].GetHidden();
                wordToChange = randomNumber;
                
                if(counter == length){
                    return true;
                }
            }
            _words[wordToChange].HideWord();
            counter++;

        }
        return false;

    }

    public void UnhideAllWords(){
        foreach(Word word in _words){
            word.ShowWord();
            counter = 0;
        }
    }




}