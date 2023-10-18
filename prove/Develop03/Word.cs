using System;

public class Word{

    private string _word;

    public string WordSetter
    {
        set
        {
            _word = value;
        }
    }

    private bool _isHidden = false;

    public bool IsHidden
    {
        get
        {
            return _isHidden;
        }

        set
        {
            _isHidden = value;
        }
    }


    //Display basically
    public void Display()
    {
        int character = 0;
        int wordLength = _word.Length;
        //if the word is not hidden, write a "-" for each character in the Word
        if (_isHidden)
        {
            while (character != wordLength)
            {
                Console.Write("-");
                character += 1;
            }
            Console.Write(" ");
        }
        else
        {
            Console.Write($"{_word} ");
        }
    }

}