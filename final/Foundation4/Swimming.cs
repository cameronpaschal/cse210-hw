using System.Runtime.InteropServices.Marshalling;

public class Swimming : Activity {


    private int _laps;

    public Swimming(string date, int minutes, int laps) : base(date, minutes){
        _laps = laps;
        _type = "Swimming";
    }


    public override double GetDistance()
    {
        return Math.Round(_laps * 50 / 1000 * .62, 1) ;
    }

    public override double GetSpeed()
    {
        return Math.Round((GetDistance() / _minutes) * 60, 1);
    }

    public override double GetPace()
    {
        return Math.Round(_minutes / GetDistance(), 1);
    }
}