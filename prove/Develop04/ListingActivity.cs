using System;
using System.Threading;

class ListingActivity : Activity
{
    private string[] _prompts =
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public ListingActivity(string activity, string description)
    {
        _activity = activity;
        _description = description;
    }


    public void StartListingActivity()
    {
        Console.WriteLine("Take a few seconds to think about the following prompt:");
        Console.WriteLine($"{_prompts[GenerateRandomNumber(4)]}");
        CountDownAnimation(10);
        Console.WriteLine("Begin listing the thoughts that come to you.");

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        
        int itemCounter = 0;
        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime)
        {
            Console.ReadLine();

            itemCounter++;
            currentTime = DateTime.Now;
        }
        Console.WriteLine($"You listed {itemCounter} things");
    }
}