using System;

class Program
{
    static void Main(string[] args)
    {
        //get magic number

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        

        //game loop
        bool keepPlaying = true;
        while (keepPlaying == true)
        {
            //get guess
            Console.WriteLine("What is your guess?");
            string userInput = Console.ReadLine();
            int userGuess = int.Parse(userInput);

            //see if guess is correct
            if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You got it!!");
                keepPlaying = false;
            }
        }
        
    }
}