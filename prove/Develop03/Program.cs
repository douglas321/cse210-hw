using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", "5", "5-6");

        var scripture = new Scripture();
        string startingScripture = ("Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        scripture.SplitString(startingScripture);

        //initial reference and scripture write
        Console.Clear();
        reference.Display();
        scripture.Display();

        bool runProgram = true;
        while (runProgram)
        {
            bool isCompletleyHidden = scripture.IsCompletleyHidden();

            Console.WriteLine("\n\nPress 'Enter' or type quit");
            string userInput = Console.ReadLine();

            //enter, hide words
            if (userInput.Length == 0 && !isCompletleyHidden)
            {
                Console.Clear();
                reference.Display();
                scripture.Hide();
                scripture.Display();
            }
            //quit
            else if (userInput == "quit" || userInput == "Quit")
            {
                runProgram = false;
            }
            //scripture is completely hidden
            else if (isCompletleyHidden)
            {
                runProgram = false;
            }
            //invalid input
            else
            {
                System.Console.WriteLine("\nInvalid Input");
            }
            
        }





    }
}