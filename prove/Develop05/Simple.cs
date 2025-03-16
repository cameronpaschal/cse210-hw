public class Simple : Goal {


    public Simple(string title, string description, int points) : base(title, description, points){
        _type = "Simple";

    }

    public override void Display(){
        if (_repetitions == 1){
            Console.Out.WriteLine($"Name: {_title} Description: {_description} Completed: Yes Points Earned: {_points}");
    
        }
        else{
            Console.Out.WriteLine($"Name: {_title} Description: {_description} Completed: No Points Earned: 0");
        }
    }

     public override int Repetition(){
        if (_repetitions == 1 ){
            Console.Out.WriteLine("Goal already completed.");
            return 0;
        }
        else{
            _repetitions += 1;
            return _points;
        }
        
    }


}