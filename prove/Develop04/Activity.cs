using System.Reflection.Metadata;

public class Activity {



    protected string _name = "default";
    protected string _description = "default";
    protected int _duration = 10;

    public Activity(){

    }

    public void DisplayTime(int duration){
        for (int x = duration; x > 0; x-- ){
            Console.Write(x);
            Thread.Sleep(1000);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
        Console.Write(" ");

    }

    public void WelcomeMessage(){
        Console.Out.WriteLine($"Welcome to the {_name} activity!\n");
        Console.Out.WriteLine(_description);
        SetDuration();
        Console.Clear();
        Console.Write("Get Ready...");
        Spinner(2);
        // Thread.Sleep(2000);
    }

    public void CompletionMessage(){
        Console.Out.WriteLine($"Well done! You completed {_duration} seconds of the {_name} activity!\n");
    }

    public void SetDuration(){
        Console.Out.WriteLine($"Please enter the duration of the {_name} exercise in seconds.");
        _duration = int.Parse(Console.ReadLine());
    }
    public int GetDuration(){
        return _duration;
    }

    public void Spinner(int seconds){
        int mSeconds = seconds * 1000;
        string[] frames = new string[]{"_", ".", "o", "0","o", ".",};

        int frameLength = 125;

        int counter = 0;

        while(counter < mSeconds){
            foreach (string frame in frames){
                Console.Out.Write(frame);
                Thread.Sleep(frameLength);
                counter += frameLength;
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
        }
        Console.Out.WriteLine(" ");

    }


}