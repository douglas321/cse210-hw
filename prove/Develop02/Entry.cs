using System;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _entry;

    

    public string GetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        return dateText;
    }

    public void DisplayEntrys()
    {
        Console.WriteLine($"\n{_date}: {_prompt}\n{_entry}\n");
    }
}
