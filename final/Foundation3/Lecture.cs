public class Lecture : Event {

    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
        _type = "Lecture";
    }

    public override string FullDetails(){
        return $"Event type: {_type} \nTitle: {_eventTitle} \nDescription: {_description} \nDate: {_date} \nTime: {_address} \nSpeaker: {_speaker} \nCapacity: {_capacity}\n";

    }




    
}