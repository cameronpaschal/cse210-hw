using System;

class Program
{
    static void Main(string[] args)
    {
        Running run = new Running("04 April 2025", 45, 7.3);
        Bicycle bicycle = new Bicycle("20 March 2025", 120, 13.5);
        Swimming swim = new Swimming("04 July 2025", 25, 50);

        List<Activity> activities = new List<Activity>{run, bicycle, swim};

        foreach (Activity activity in activities){
            Console.Out.WriteLine(activity.GetSummary());
            Console.Out.WriteLine();
            
        }
    }
}