using System;

// Address class
public class Address
{
    private string street;
    private string city;
    private string state;
    private string zipCode;

    public string Street
    {
        get { return street; }
        set { street = value; }
    }

    public string City
    {
        get { return city; }
        set { city = value; }
    }

    public string State
    {
        get { return state; }
        set { state = value; }
    }

    public string ZipCode
    {
        get { return zipCode; }
        set { zipCode = value; }
    }

    public override string ToString()
    {
        return $"{Street}, {City}, {State} {ZipCode}";
    }
}

// Event class (base class)
public class Event
{
    private string title;
    private string description;
    private string date;
    private string time;
    private Address address;

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    public string Date
    {
        get { return date; }
        set { date = value; }
    }

    public string Time
    {
        get { return time; }
        set { time = value; }
    }

    public Address Address
    {
        get { return address; }
        set { address = value; }
    }

    public virtual string GetStandardDetails()
    {
        return $"Event: {Title}\nDescription: {Description}\nDate: {Date}\nTime: {Time}\nAddress: {Address}";
    }

    public virtual string GetFullDetails()
    {
        return $"{GetStandardDetails()}";
    }

    public virtual string GetShortDescription()
    {
        return $"Title: {Title}\nDate: {Date}";
    }
}

// Lecture class (derived from Event)
public class Lecture : Event
{
    private string speaker;
    private int capacity;

    public string Speaker
    {
        get { return speaker; }
        set { speaker = value; }
    }

    public int Capacity
    {
        get { return capacity; }
        set { capacity = value; }
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Lecture\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }

    public override string GetShortDescription()
    {
        return $"Type: Lecture\nTitle: {Title}\nDate: {Date}";
    }
}

// Reception class (derived from Event)
public class Reception : Event
{
    private string rsvpEmail;

    public string RsvpEmail
    {
        get { return rsvpEmail; }
        set { rsvpEmail = value; }
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Reception\nRSVP Email: {RsvpEmail}";
    }

    public override string GetShortDescription()
    {
        return $"Type: Reception\nTitle: {Title}\nDate: {Date}";
    }
}

// OutdoorGathering class (derived from Event)
public class OutdoorGathering : Event
{
    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Outdoor Gathering\nWeather: Sunny";
    }

    public override string GetShortDescription()
    {
        return $"Type: Outdoor Gathering\nTitle: {Title}\nDate: {Date}";
    }
}

class Program
{
    static void Main()
    {
        // Examples
        Address address1 = new Address { Street = "9237 MC sq", City = "Rexburg", State = "ID", ZipCode = "12321" };
        Lecture lectureEvent = new Lecture { Title = "Thursday Devo", Description = "Come and be edified by the Spirit.", Date = "2023-01-01", Time = "11:00", Address = address1, Speaker = "Brother Brown", Capacity = 11000 };

        Address address2 = new Address { Street = "777 Porter Park st", City = "Rexburg", State = "ID", ZipCode = "12321" };
        Reception receptionEvent = new Reception { Title = "Wedding Reception", Description = "Come take your BeReal and feel included", Date = "2023-02-02", Time = "12:00", Address = address2, RsvpEmail = "shotgunwedding@byuido.com" };

        Address address3 = new Address { Street = "893 Ropes Course Way", City = "Rexburg", State = "State", ZipCode = "12321" };
        OutdoorGathering outdoorEvent = new OutdoorGathering { Title = "FHE Activity", Description = "Fun outdoor activities and free food!!!", Date = "2023-03-03", Time = "7:00", Address = address3 };

        // Printing details for each example
        Console.WriteLine("\n--- Standard Details ---");
        Console.WriteLine(lectureEvent.GetStandardDetails());

        Console.WriteLine("\n--- Full Details ---");
        Console.WriteLine(lectureEvent.GetFullDetails());

        Console.WriteLine("\n--- Short Description ---");
        Console.WriteLine(lectureEvent.GetShortDescription());

        Console.WriteLine("\n--- Standard Details ---");
        Console.WriteLine(receptionEvent.GetStandardDetails());

        Console.WriteLine("\n--- Full Details ---");
        Console.WriteLine(receptionEvent.GetFullDetails());

        Console.WriteLine("\n--- Short Description ---");
        Console.WriteLine(receptionEvent.GetShortDescription());

        Console.WriteLine("\n--- Standard Details ---");
        Console.WriteLine(outdoorEvent.GetStandardDetails());

        Console.WriteLine("\n--- Full Details ---");
        Console.WriteLine(outdoorEvent.GetFullDetails());

        Console.WriteLine("\n--- Short Description ---");
        Console.WriteLine(outdoorEvent.GetShortDescription());
    }
}
