using System;

class Program
{
    static void Main(string[] args)
    {
        var scripture = new Scripture();
        Reference reference = new Reference("Proverbs", "5", "5-6");

        
        string startingScripture = ("Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        scripture.SplitString(startingScripture);
        
        bool runProgram = true;
        while (runProgram)
        {
            bool finished = scripture.IsCompletleyHidden();
            //Print scripture
            Console.WriteLine("\nPress 'Enter' or type quit");
            string userInput = Console.ReadLine();

            
            if (userInput.Length == 0 && finished)
            {
                Console.Clear();
                reference.Display();
                scripture.Hide();
                scripture.Display();
                //enter, hide words
                
            }
            
            else if (userInput == "quit" || userInput == "Quit")
            {
                runProgram = false;
            }
            else if (!finished)
            {
                runProgram = false;
            }
            else
            {
                System.Console.WriteLine("invalid input");
            }
            
        }





    }
}