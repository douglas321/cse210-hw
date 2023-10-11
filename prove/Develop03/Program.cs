using System;

class Program
{
    static void Main(string[] args)
    {
        string startingScripture = "Proverbs 3:5-6 Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."
        
        //Remove reference from scripture
        
        bool runProgram = true;
        while (runProgram)
        {
            //Print scripture
            Console.WriteLine("Press 'Enter' or type quit");
            string userInput = Console.ReadLine();

            
            if (userInput.Length == 0)
            {
                Console.Clear();
                Console.WriteLine("scripture");
                //enter, hide words
            }
            
            else if (userInput == "quit" || userInput == "Quit")
            {
                runProgram = false;
            }
        }





    }
}