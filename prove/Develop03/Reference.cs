using System.ComponentModel.DataAnnotations;

public class Reference {

    private string _book;
    private int _chapter;
    private string _verse;

    public Reference(){
        
    }


    public void SetBook(string book){
        _book = book;
    }
    public string GetBook(){
        return _book;
    }
    public void SetChapter(int chapter){
        _chapter = chapter;
    }
    public int GetChapter(){
        return _chapter;
    }

    public void SetVerse(string verse){
        _verse = verse;
    }
    public string GetVerse(){
        return _verse;
    }

    public void Display(){
        Console.Out.WriteLine($"{_book} {_chapter}:{_verse}");
    }




}