using System;

class Program
{
    static void Main(string[] args)
    {
        //ask user for grade percentage
        Console.WriteLine("What is your grade percentage in class?");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);

        //using if statements determine letter grade and print
        string letterGrade = "";
        
        if (gradePercentage >= 90)
        {
            letterGrade = ("A");
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = ("B");
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = ("C");
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = ("D");
        }
        else
        {
            letterGrade = ("F");
        }

        Console.WriteLine($"Your grade is a(n) {letterGrade}.");

        //If grade is higher than 70 congradulate for passing else incurage them

        if (letterGrade == "A" || letterGrade == "B" || letterGrade == "C")
        {
            Console.WriteLine("Congrats on passing the class!!");
        }

        else
        {
            Console.WriteLine("Not quite a pass, but I know you can do it!");
        }
    }
}