using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Threading;

class Activity
{
    protected string _activity = "";
    protected string _description = "";
    protected int _duration = 0;

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activity} activity. {_description}");
        Console.WriteLine("How many seconds would you like to do this activity?");
        string userInput; 
        userInput = Console.ReadLine();
        _duration = int.Parse(userInput);

        SpinnerAnimation(5);
    }

    public void EndActivity()
    {
        Console.WriteLine($"Thank you for completing the {_activity} activity.");
        Console.WriteLine($"Activity run time: {_duration} seconds");
        Thread.Sleep(5000);
    }

    public void SpinnerAnimation(int seconds)
    {
            DateTime startTime = DateTime.Now;
            DateTime stop = startTime.AddSeconds(seconds);

            DateTime currentTime = DateTime.Now;

        while (currentTime < stop){
            Console.Write("|");

            Thread.Sleep(500);

            Console.Write("\b \b"); 
            Console.Write("\\");

            Thread.Sleep(500);

            Console.Write("\b \b"); 
            Console.Write("-");

            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("/");

            Thread.Sleep(500);
            Console.Write("\b \b");
            currentTime = DateTime.Now;
        }
        Console.Clear();
    }

    public int GenerateRandomNumber(int maxValue)
    {
        Random random = new Random();

        int randomNumber = random.Next(maxValue + 1);

        return randomNumber;
    }
    public void CountDownAnimation(int startingNumber)
    {
        int count = startingNumber;
        while (count >= 0)
        {
            Console.Write(count + " ");
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b");
            count--;
        }

        
    }
}