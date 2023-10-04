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
    public void SaveFile(List<Entry> journal)
    {
        var entry = new Entry();
        using (StreamWriter outputFile = new StreamWriter("myFile.txt"))
        {
            //outputFile.WriteLine($"{entry.DisplayEntrys()}");
        }
 
    }
    //load
}