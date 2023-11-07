using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the Mindfulness App!");


        bool run = true;
        while (run)
        {
            Console.Clear();
            Console.WriteLine("Choose an activity to start:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    BreathingActivity A1 = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    A1.StartActivity();
                    A1.StartBreathingActivity();
                    A1.EndActivity();
                    break;
                case "2":
                    ReflectionActivity A2 = new ReflectionActivity("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    A2.StartActivity();
                    A2.StartReflectionActivity();
                    A2.EndActivity();
                    break;
                case "3":
                    ListingActivity A3 = new ListingActivity("Listening", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    A3.StartActivity();
                    A3.StartListingActivity();
                    A3.EndActivity();
                    break;
                case "4":
                    run = false;
                    break;
            }
        }
    }
}
