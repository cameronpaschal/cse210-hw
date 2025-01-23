
using System.Reflection.Metadata.Ecma335;

class Resume{

    public String _name;
    public List<Job> _jobs = [];

    public Resume() {
        
    }

    public void Display() {
        Console.WriteLine("Name: " + _name);
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs) {
            job.Display();
        }
    }

}