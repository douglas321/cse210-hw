using System;

class Program
{
    static void Main(string[] args)
    {

           //function calls
        WelcomeMessage();
        string name = PromptUserName();
        int favNum = PromptUserNum();

        int squarNum = SquareNumber(favNum);

        DisplayResults(name, squarNum);



        //write functions
        void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        string PromptUserName()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            return name;
        }

        int PromptUserNum()
        {
            Console.WriteLine("Pick a number");
            string userInput = Console.ReadLine();
            int num = int.Parse(userInput);
            return num;
        }

        int SquareNumber(int num)
        {
            int squNum = num * num;
            return squNum;
        }
        
        void DisplayResults(string userName, int num)
        {
            System.Console.WriteLine($"{userName}, the square of your number is {num}.");
        }
    }
}