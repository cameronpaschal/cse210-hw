using System;

class Program
{
    static void Main(string[] args)
    {

        Lecture lecture = new Lecture("Devotional", "Listen to an apostle speak at the devotional", "04/06/2025", "11:00 AM", CreateAddress("123 Viking Dr", "Rexburg", "Idaho", "United States"), "Elder David A. Bednar", 20000);

        Reception reception = new Reception("Wedding", "Wedding of Jack and Jill", "05/04/2025", "10:00 AM", CreateAddress("123 Venue St", "Salt Lake City", "Utah", "United States"), "jackandjill@email.com");

        Outdoor outdoor = new Outdoor("Family Reunion", "Family reunion of the Smith family", "07/04/2025", "12:00 PM", CreateAddress("123 Smith Farm Rd", "Palmyra", "New York", "United States"), "Sunny");

        List<Event> events = new List<Event> {lecture, reception, outdoor};

        foreach (Event _event in events){
            Console.Out.WriteLine(_event.StandardDetails());
            Console.Out.WriteLine(_event.FullDetails());
            Console.Out.WriteLine(_event.ShortDescription());
            Console.Out.WriteLine();
        }
        
    }

    public static Address CreateAddress(string street, string city, string state, string country){
        Address address = new Address(street, city, state, country);
        return address;
    }

}