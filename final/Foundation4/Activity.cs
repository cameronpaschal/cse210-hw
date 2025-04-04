using System.Diagnostics.Contracts;
using System.IO.Pipes;
using Microsoft.VisualBasic;

public abstract class Activity{


    protected string _date;
    protected int _minutes;
    protected string _type;

    public Activity(string date, int minutes){
        _date = date;
        _minutes = minutes;
        _type = "Activity";
    }


    public string GetDate(){
        return _date;
    }
    public int GetMinutes(){
        return _minutes;
    }


    public virtual double GetSpeed(){

        return 0.0;


    }
    public virtual double GetDistance(){
        return 0.0;

    }
    public virtual double GetPace(){

        return 60 / GetSpeed();
    }

    public string GetActivityType(){
        return _type;
    }
    public virtual string GetSummary(){
        return $"{GetDate()} {GetActivityType()} ({GetMinutes()} min)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";

    }


}