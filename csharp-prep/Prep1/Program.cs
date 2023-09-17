using System;

class Program
{
    static void Main(string[] args)
    {
        //ask for first and last name then display both on same line
        Console.WriteLine("What is your first name?");
        string firstName = Console.ReadLine();

        Console.WriteLine("What is your last name?");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is " + firstName + ", " + lastName + " " + firstName + ".");

    }
}