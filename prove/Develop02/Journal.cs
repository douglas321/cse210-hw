using System;
using System.IO;

public class Journal
{
    public List<Entry> _entrys = new List<Entry>();

    public void Display()
    {
        foreach (Entry entry in _entrys)
        {
            entry.DisplayEntrys();
        }
    }

    //save
    public void SaveFile()
    
    {
       Console.WriteLine("What would you like to name your new journal?");
       string myFile = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter($"{myFile}.txt"))
        {
            int x = 0;
            foreach (Entry entry in _entrys)
            {
                
                outputFile.WriteLine($"{_entrys[x]._date}:{_entrys[x]._prompt}:{_entrys[x]._entry}:");
                x += 1;
            }
        }
 
    }
    //load
    public void LoadFile()
    {
        
        Console.WriteLine("Which file would you like to load?");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            var entry1 = new Entry();
            string[] parts = line.Split(":");

            entry1._date = parts[0];
            entry1._prompt = parts[1];
            entry1._entry = parts[2];

            _entrys.Add(entry1);
        }
    }
}