public class Reception : Event {
    private string _rsvpEmail;


    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail) : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
        _type = "Reception";
    }

    public override string FullDetails(){
        return $"Event type: {_type} \nTitle: {_eventTitle} \nDescription: {_description} \nDate: {_date} \nTime: {_address} \nRSVP Email: {_rsvpEmail}\n";

    }
}