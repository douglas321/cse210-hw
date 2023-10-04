using System;
using System.IO;

public class Journal
{
    //save
    public void SaveFile(List<Entry> journal)
    {
        var entry = new Entry();
        using (StreamWriter outputFile = new StreamWriter("myFile.txt"))
        {
            outputFile.WriteLine($"{entry.DisplayEntrys()}");
        }
 
    }
    //load
}