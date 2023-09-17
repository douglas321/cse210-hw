using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        //string Interpolation
        int  myInt = 5;
        Console.WriteLine(myInt);
        Console.WriteLine("my int =" + myInt);
        Console.WriteLine($"my int = {myInt}");

        //ReadLine
        Console.Write("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine(name);

        //Conditionals
        if (name == "Carter")
        {
            Console.WriteLine("Welcome Carter!");
        } 
        else 
        {
            Console.WriteLine("Intruder!");
        }
    }
}