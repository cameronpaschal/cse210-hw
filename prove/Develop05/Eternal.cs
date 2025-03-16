

public class Eternal : Goal {

    public Eternal(string title, string description, int points) : base(title, description, points){
        _type = "Eternal";
    }

    public override void Display(){
        Console.Out.WriteLine($"Name: {_title} Description: {_description} Repetitions: {_repetitions} Points Earned: {(_points * _repetitions)}");
    }

}