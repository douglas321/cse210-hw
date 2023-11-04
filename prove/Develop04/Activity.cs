using System;
using System.Threading;

class Activity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Duration { get; private set; } // Make Duration private with a public getter

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void StartActivity()
    {
        Console.WriteLine($"Starting {Name} Activity: {Description}");
        Console.Write("Enter the duration in seconds: ");
        int duration = Console.Read();
        Duration = duration; // Assign the duration value to the private property
    }

    public void EndActivity()
    {
        Console.WriteLine($"Congratulations! You've completed the {Name} Activity in {Duration} seconds.");
        Console.WriteLine($"You have done a good job!");
    }
}

