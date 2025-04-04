public class Bicycle : Activity {

    private double _speed;


    public Bicycle(string date, int minutes, double speed) : base(date, minutes){
        _speed = speed;
        _type = "Bicycle";
    }

    public override double GetDistance()
    {
        return Math.Round(_speed * (_minutes / 60), 1);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return Math.Round(60 / _speed, 1);
    }
}