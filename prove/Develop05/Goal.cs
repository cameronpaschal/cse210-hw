public class Goal{

    protected string _type;
    protected int _points;
    protected string _title;
    protected string _description;

    protected int _repetitions = 0;

    public Goal(string title, string description, int points){
        _points = points;
        _title = title;
        _description = description;
    }

    public virtual int Repetition(){
        _repetitions += 1;
        return _points;
    }
    public int GetRepetitions(){
        return _repetitions;
    }

    public string GetGoalType(){
        return _type;
    }

    public virtual void Display(){
        Console.Out.Write($"Name: {_title} \nDescription: {_description} \nPoints Possible: {_points}");
    }

    public string GetInfo(){
        return $"Name: {_title}, Description: {_description}, Points: {_points}";
    }

    public virtual int GetRepetitionsNeeded(){
        return 0;
    }

    public virtual int GetBonus(){
        return 0;
    }

    public string GetTitle(){
        return _title;
    }

    public string GetDescription(){
        return _description;
    }

    public int GetPoints(){
        return _points;
    }






    
}  