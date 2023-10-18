using System;

public class Scripture{
    
    private List<Word> _words = new List<Word>();

    public void SplitString(string scripture)
    {
        string[] words = scripture.Split(' ');
        foreach (string wrd in words)
        {
            var word = new Word();
            word.WordSetter = wrd;
            _words.Add(word);
        }
    }

    //Display scripture
    public void Display()
    {
        foreach (Word word in _words)
        {
            word.Display();
        }
    }
    
    //Hide Words
    public void Hide()
    {
            double i = 0;
            while (i < 3)
            {
                int randomIndex = RandNumber();

                if (_words[randomIndex].IsHidden == true)
                {
                    //an attempt to replace only visible words while not getting stuck in an infinite loop
                    i = i +.01;
                }
                else
                {
                    _words[randomIndex].IsHidden = true;
                    i++;
                }
            }
    }
    
    private int RandNumber()
    {
        int length = _words.Count;
        Random random = new Random();

        int randomNumber = random.Next(0, length);

        return randomNumber;
    }
    //check if all Words in _words are hidden
    public bool IsCompletleyHidden()
    {
        bool isCompletleyHidden = _words.All(word => word.IsHidden);
        
        return isCompletleyHidden;
    }
}