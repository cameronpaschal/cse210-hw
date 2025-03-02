

public class Breathe : Activity {

    
    public Breathe(){
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void MainProgram(){

        WelcomeMessage();

        int breathTime = _duration / 4;

        for (int x = 0; x < _duration; x++){
            x += BreatheIn(breathTime);
            x += BreatheOut(breathTime);
        }

        CompletionMessage();
    }

    public int BreatheIn(int breathTime){
        Console.Out.Write("Breathe in...");
        DisplayTime(breathTime);
        Console.Out.WriteLine();
        return breathTime;
    }

    public int BreatheOut(int breathTime){
        Console.Out.Write("Breathe out...");
        DisplayTime(breathTime);
        Console.Out.WriteLine();
        return breathTime;
    }

}
