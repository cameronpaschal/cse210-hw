public class Outdoor : Event {
    private string _weather;

    public Outdoor(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
        _type = "Outdoor";
    }

    public override string FullDetails(){
        return $"Event type: {_type} \nTitle: {_eventTitle} \nDescription: {_description} \nDate: {_date} \nTime: {_address} \nWeather: {_weather}\n";

    }
}