using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness App!");

        Console.WriteLine("Choose an activity to start:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");

        if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= 3)
        {
            Activity activity = null;
            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity();
                    break;
                case 2:
                    activity = new ReflectionActivity();
                    break;
                case 3:
                    activity = new ListingActivity();
                    break;
            }

            if (activity != null)
            {
                if (choice == 3)
                {
                    Console.WriteLine("Note: To end the Listing Activity, press Enter without entering any item.");
                }
                activity.StartActivity();

                if (choice == 3)
                {
                    Console.WriteLine("Enter items one by one and press Enter. To finish, just press Enter without entering an item.");
                }
                activity.EndActivity();
            }
        }
        else
        {
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
        }
    }
}
