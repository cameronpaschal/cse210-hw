

public abstract class Event{
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    protected string _type;

    public Event(string eventTitle, string description, string date, string time, Address address){
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = "none";
    }


    public string StandardDetails(){
        return $"Title: {_eventTitle} \nDescription: {_description} \nDate: {_date} \nTime: {_address}\n";
    }
    public abstract string FullDetails();
    public string ShortDescription(){
        return $"Event type: {_type} \nTitle: {_eventTitle} \nDate: {_date}\n";
    }

}