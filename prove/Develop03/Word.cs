using System;
using System.ComponentModel.DataAnnotations;

class Word
{
    // Class attributes
    private string _word;
    private string _hiddenWord;

    // Constuctor
    public Word(string word)
    {
        _word = word;
        _hiddenWord = HideWord(word);
    }

    // Class Methods
    // https://stackoverflow.com/questions/8879774/how-can-i-check-if-a-string-contains-a-character-in-c
    private string HideWord(string word)
    {
        string hiddenWord = "";

        if (_word.Contains(',')) // word contains comma
        {
            int wordLength = word.Length;
            for (int i = 1; i < wordLength; i++)
            {
                hiddenWord += "_";
            }

            hiddenWord += ",";
        }

         else if (_word.Contains('.')) // word contains period
        {
            int wordLength = word.Length;
            for (int i = 1; i < wordLength; i++)
            {
                hiddenWord += "_";
            }

            hiddenWord += ".";
        }

        else // Word contains neither comma nor period
        {
            int wordLength = word.Length+1;
            for (int i = 1; i < wordLength; i++)
            {
                hiddenWord += "_";
            }
        }
        return hiddenWord;
    }

    public void Test()
    {
        Console.WriteLine($"{_word}   {_hiddenWord}");
    }

    public string GetWord(bool maskStatus) // mask true = _hiddenWord
    {
        if (maskStatus == false)
        {
            return _word;
        }

        else
        {
            return _hiddenWord;
        }
    }
}