using System;
using System.Collections.Generic;

// Base Activity class
public class Activity
{
    private DateTime date;
    private int minutes;

    public DateTime Date
    {
        get { return date; }
        set { date = value; }
    }

    public int Minutes
    {
        get { return minutes; }
        set { minutes = value; }
    }

    // Constructor
    public Activity(DateTime date, int minutes)
    {
        Date = date;
        Minutes = minutes;
    }

    // Virtual methods to be overridden by derived classes
    public virtual double GetDistance()
    {
        return 0.0;
    }

    public virtual double GetSpeed()
    {
        return 0.0;
    }

    public virtual double GetPace()
    {
        return 0.0;
    }

    // Polymorphic summary method
    public virtual string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} - {GetType().Name} ({Minutes} min)";
    }
}

// Running class (derived from Activity)
public class Running : Activity
{
    private double distance;

    public double Distance
    {
        get { return distance; }
        private set { distance = value; }
    }

    // Constructor
    public Running(DateTime date, int minutes, double distance)
        : base(date, minutes)
    {
        Distance = distance;
    }

    // Override methods
    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return Distance / (Minutes / 60.0);
    }

    public override double GetPace()
    {
        return Minutes / Distance;
    }

    // Override summary method
    public override string GetSummary()
    {
        return base.GetSummary() + $" - Distance: {Distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}

// Cycling class (derived from Activity)
public class Cycling : Activity
{
    private double speed;

    public double Speed
    {
        get { return speed; }
        private set { speed = value; }
    }

    // Constructor
    public Cycling(DateTime date, int minutes, double speed)
        : base(date, minutes)
    {
        Speed = speed;
    }

    // Override methods
    public override double GetDistance()
    {
        return Speed * (Minutes / 60.0);
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60.0 / Speed;
    }

    // Override summary method
    public override string GetSummary()
    {
        return base.GetSummary() + $" - Speed: {GetSpeed()} kph, Distance: {GetDistance()} km, Pace: {GetPace()} min per km";
    }
}

// Swimming class (derived from Activity)
public class Swimming : Activity
{
    private int laps;

    public int Laps
    {
        get { return laps; }
        private set { laps = value; }
    }

    // Constructor
    public Swimming(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        Laps = laps;
    }

    // Override methods
    public override double GetDistance()
    {
        return Laps * 50.0 / 1000.0; // Convert laps to kilometers
    }

    public override double GetSpeed()
    {
        return GetDistance() / (Minutes / 60.0);
    }

    public override double GetPace()
    {
        return Minutes / GetDistance();
    }

    // Override summary method
    public override string GetSummary()
    {
        return base.GetSummary() + $" - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}

class Program
{
    static void Main()
    {
        // Example usage with polymorphism
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 03), 45, 5.0),
            new Cycling(new DateTime(2022, 11, 04), 30, 25.0),
            new Swimming(new DateTime(2022, 11, 05), 60, 40)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
