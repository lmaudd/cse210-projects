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
    private string HideWord(string word)
    {
        int wordLength = word.Length+1;
        string hiddenWord = "";

        for (int i = 1; i < wordLength; i++)
        {
            hiddenWord += "_";
        }

        return hiddenWord;
    }

    public string GetWord(bool maskStatus=false) // mask true = _hiddenWord
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