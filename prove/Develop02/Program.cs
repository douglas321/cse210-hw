using System;

class Program
{
    static void Main(string[] args)
    {
        
        bool running = true;
        var myJournal = new Journal();
        while (running)
        {
            Console.WriteLine("Please select one of the following: \n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1": //Write
                    

                    //start a new entry
                    var entry1 = new Entry();
                    //display random prompt
                    Random rnd = new Random();
                    int promptNumber = rnd.Next(5);

                    var generatePrompt = new GeneratePrompt();
                    System.Console.WriteLine($"{generatePrompt.promptsList[promptNumber]}");
                    //give text box and set as userEntry
                    string userEntry = Console.ReadLine();
                    //save date, prompt, and entry and add it to entrys list
                    entry1._date = entry1.GetDate();
                    entry1._prompt = generatePrompt.promptsList[promptNumber];
                    entry1._entry = userEntry;
                    //add entry to list in Journal
                    myJournal._entrys.Add(entry1);
                break;

                case "2": //Display

                   myJournal.Display();

                break;

                case "3": //Load

                    myJournal.LoadFile();

                break;
                case "4": //Save

                    myJournal.SaveFile();

                break;
                default: //Quit
                    running = false;
                break;
            }
        }
    }
}