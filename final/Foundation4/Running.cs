public class Running : Activity {

    private double _distance;

    public Running(string date, int minutes, double distance) : base(date, minutes){
        _distance = distance;
        _type = "Running";
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        
        return Math.Round((_distance / _minutes) * 60,1);
    }

    public override double GetPace()
    {
        return Math.Round(60 / GetSpeed(), 1);
    }
}