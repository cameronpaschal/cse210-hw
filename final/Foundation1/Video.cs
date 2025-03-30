using System.Transactions;

public class Video{

    private string _title;
    private string _author;
    private int _length;

    List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length){
        _title = title;
        _author = author;
        _length = length;
    }

    public void SetTitle(string title){
        _title = title;
    }

    public void SetAuthor(string author){
        _author = author;
    }

    public void SetLength(int length){
        _length = length;
    }

    public string GetTitle(){
        return _title;
    }

    public string GetAuthor(){
        return _author;
    }
    public int GetLength(){
        return _length;
    }

    public void AddComment(Comment comment){
        _comments.Add(comment);
    }

    public void NumberOfComments(){
        Console.Out.WriteLine($"{_title} currently has {_comments.Count()} comments.");
    }

    public void DisplayComments(){
        foreach (Comment comment in _comments){
            comment.Display();
        }
    }

    public void Display(){
        Console.Out.WriteLine($"Title: {_title}");
        Console.Out.WriteLine($"Author: {_author}");
        Console.Out.WriteLine($"Length: {_length} seconds\n");
        NumberOfComments();
        DisplayComments(); 
        Console.Out.WriteLine();
    }









}