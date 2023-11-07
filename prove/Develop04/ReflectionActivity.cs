using System;
using System.Security.Cryptography;
using System.Threading;

class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions  = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?"
    };
    public ReflectionActivity(string activity, string description)
        {
            _activity = activity;
            _description = description;
        }

    public void StartReflectionActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        string randomPrompt = _prompts[GenerateRandomNumber(3)];
        Console.WriteLine($"{randomPrompt}");
        Thread.Sleep(5000);

        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime)
        {
            string randomQuestion = _questions[GenerateRandomNumber(4)];
            Console.WriteLine($"{randomQuestion}");
            SpinnerAnimation(10);
            
            currentTime = DateTime.Now;

        }
    }
}
