

public class Checklist : Goal {


    private int _bonus;
    private int _repetitionsNeeded;

    public override int GetBonus(){
        return _bonus;
    }

    public void SetBonus(int bonus){
        _bonus = bonus;
    }

    public Checklist(string title, string description, int points, int bonus, int repetitionsNeeded) : base(title, description, points){
        _bonus = bonus;
        _repetitionsNeeded = repetitionsNeeded;
        _type = "Checklist";
    }

    public override void Display(){
        int pointsEarned = _points * _repetitions;

        if ((_repetitions % _repetitionsNeeded) == 0) {

            pointsEarned += _bonus * (_repetitions / _repetitionsNeeded);
        }
        Console.Out.WriteLine($"Name: {_title} Description: {_description} Repetitions: {_repetitions} Points Earned: {pointsEarned} Repetitions: ({_repetitions} / {_repetitionsNeeded})");
    }

    public override int GetRepetitionsNeeded(){
        return _repetitionsNeeded;
    }

    public override int Repetition(){

        _repetitions += 1;

        if ((_repetitions % _repetitionsNeeded) == 0) {

            return _points + _bonus;
        }
        else{
            return _points;
        }
    
    }








}