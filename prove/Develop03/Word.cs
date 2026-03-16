// https://stackoverflow.com/questions/8879774/how-can-i-check-if-a-string-contains-a-character-in-c

using System;

class Word
{
    // Class attributes ///////////////////////////////////////////////
    private string _word;
    private string _hiddenWord;
    private bool _maskStatus;

    // Constuctor /////////////////////////////////////////////////////
    public Word(string word)
    {
        _word = word;
        _hiddenWord = HideWord(word);
        _maskStatus = false;
    }

    // Class Methods ///////////////////////////////////////////////////
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

    public bool GetMaskStatus()
    {
        return _maskStatus;
    }

    public void SetMaskStatus(bool newStatus)
    {
        _maskStatus = newStatus;
    }

    public string GetWord()
    {
        if (_maskStatus == false)
        {
            return _word;
        }

        else
        {
            return _hiddenWord;
        }
    }
}