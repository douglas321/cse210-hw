using System;
using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    public void StartBreathingActivity()
    {
        
        StartActivity();

        Console.WriteLine("Let's begin...");
        int secondsElapsed = 0;

        while (secondsElapsed < Duration)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(4000); // Wait for 4 seconds

            Console.WriteLine("Breathe out...");
            Thread.Sleep(4000); // Wait for 4 seconds

            secondsElapsed += 8; // Each cycle takes 8 seconds
        }

        EndActivity();
    }
}

