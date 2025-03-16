using System.Net;

public class IndividualRecord{
    private string _name;

    private int _pointsEarned = 0;

    private List<Goal> _goals = new List<Goal>();

    public IndividualRecord(string name){
        _name = name;
    }

    public IndividualRecord(string name, List<Goal> goals){
        _name = name;
        _goals = goals;
    }

    public List<Goal> GetGoals(){
        return _goals;
    }

    public void SetGoals(List<Goal> goals){
        _goals = goals;
    }

    public void AddPoints(int points){
        _pointsEarned += points;
    }

    public void DisplayPoints(){
        Console.Out.WriteLine($"{_name} has earned {_pointsEarned} points.");
    }

    public void ListGoals(){
        int count = 1;
        if (_goals.Count() == 0){
            Console.Out.WriteLine("Sorry, no goals to display");
            return;
        }
        foreach(Goal goal in _goals){
            string checkbox;
            switch(goal.GetGoalType()){
                case "Simple":
                    if(goal.GetRepetitions() == 0){
                        checkbox = "[]";
                    }
                    else{
                        checkbox = "[x]";
                    }
                    break;
                case "Eternal":
                    checkbox = "[]";
                    break;
                case "Checklist":
                    if (goal.GetRepetitions() == goal.GetRepetitionsNeeded()){
                        checkbox = "[x]";
                    }
                    else{
                        checkbox = "[]";
                    }   
                    break;
                default: 
                    checkbox = "[]";
                    break;
            }
            Console.Out.Write($"{count}. {checkbox} ");
            goal.Display();
            count += 1;
        }
    }

    public void LoadGoals(string filePath){

        using(StreamReader reader = new StreamReader(filePath)){
            string line;
            while ((line = reader.ReadLine()) != null) {
                string[] values = line.Split(',');
                switch(values[0]){
                    case "Simple":
                        Simple simpleGoal = new Simple(values[1], values[2], int.Parse(values[3]));
                        _goals.Add(simpleGoal);
                        break;
                    case "Eternal":
                        Eternal eternalGoal = new Eternal(values[1], values[2], int.Parse(values[3]));
                        _goals.Add(eternalGoal);
                        break;
                    case "Checklist":
                        Checklist checklistGoal = new Checklist(values[1], values[2], int.Parse(values[3]), int.Parse(values[4]), int.Parse(values[5]));
                        _goals.Add(checklistGoal);
                        break;
                    default :
                        continue;
                        
                    
                }
            }
        }
    }

    public void SaveGoals(string filePath){
        using(StreamWriter writer = new StreamWriter(filePath)){

            writer.WriteLine("Type,Title,Description,Points,Repetitions,Bonus,Bonus Repetitions");
            string line = "";
            foreach (Goal goal in _goals){
                switch(goal.GetGoalType()){
                    case "Checklist": 
                        line = $"{goal.GetType()}, {goal.GetTitle()}, {goal.GetDescription()}, {goal.GetPoints()}, {goal.GetRepetitions()}, {goal.GetBonus()}, {goal.GetRepetitionsNeeded()}";
                        break;
                    default: 
                        line = $"{goal.GetType()}, {goal.GetTitle()}, {goal.GetDescription()}, {goal.GetPoints()}, {goal.GetRepetitions()}";
                        break;
                }
                
                writer.WriteLine(line);
            }
        }
    }

    public void AddGoal(){
        bool validGoal = true;

        Console.Out.WriteLine("Would you like to make a simple, eternal or checklist goal? Please enter a number reflecting your choice\n1. Simple \n2. Eternal \n3. Checklist");

        while(validGoal){

            string type = Console.ReadLine();

            switch(type){
                case "1":
                    _goals.Add(AddSimpleGoal());
                    validGoal = false;
                    break;
                case "2":
                    _goals.Add(AddEternalGoal());
                    validGoal = false;
                    break;
                case "3":
                    _goals.Add(AddChecklistGoal());
                    validGoal = false;
                    break;
                default:
                    Console.Out.WriteLine("Please enter either 1, 2 or 3");
                    break;
            }
        }
    }

    public Simple AddSimpleGoal(){
        Console.Out.WriteLine("What is the title of your goal?");
        string title = Console.ReadLine();
        Console.Out.WriteLine("Please provide a brief description of your goal");
        string description = Console.ReadLine();
        Console.Out.WriteLine("How many points do you want awarded upon completion?");
        int points = int.Parse(Console.ReadLine());
        Simple simple = new Simple(title, description, points);
        return simple;
    }

    public Eternal AddEternalGoal(){
        Console.Out.WriteLine("What is the title of your goal?");
        string title = Console.ReadLine();
        Console.Out.WriteLine("Please provide a brief description of your goal");
        string description = Console.ReadLine();
        Console.Out.WriteLine("How many points do you want awarded upon each completion?");
        int points = int.Parse(Console.ReadLine());
        Eternal eternal = new Eternal(title, description, points);
        return eternal;
    }

    public Checklist AddChecklistGoal(){
        Console.Out.WriteLine("What is the title of your goal?");
        string title = Console.ReadLine();
        Console.Out.WriteLine("Please provide a brief description of your goal");
        string description = Console.ReadLine();
        Console.Out.WriteLine("How many points do you want awarded upon each completion?");
        int points = int.Parse(Console.ReadLine());
        Console.Out.WriteLine("How many repetitions are required before a bonus is awarded?");
        int repetitions = int.Parse(Console.ReadLine());
        Console.Out.WriteLine("How many points should be awarded as a bonus?");
        int bonus = int.Parse(Console.ReadLine());
        Checklist checklist = new Checklist(title, description, points, bonus, repetitions);
        return checklist;

    }





}