using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<Entry> entrys = new List<Entry>();
        
        bool running = true;
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

                    entrys.Add(entry1);  
                break;

                case "2": //Display
                    foreach (Entry entry in entrys)
                    {
                        entry.DisplayEntrys();
                    }
                   
                break;

                case "3": //Load
                break;
                case "4": //Save
                    var journal = new Journal();
                    journal.SaveFile(entrys);
                break;
                default: //Quit
                    running = false;
                break;
            }
        }
    }
}