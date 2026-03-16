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
        _word = word;                  // Preload _word with string
        _hiddenWord = HideWord(word);  // Preload _hiddenWord with string replaced by '_'
        _maskStatus = false;           // Preload _maskStatus to false for now
    }

    // Class Methods ///////////////////////////////////////////////////
    private string HideWord(string word)
    {
        string hiddenWord = "";  // Initialize this and populate later

        // Account for words that might be followed by a comma, for example
        // so that _hiddenWord goes from "word," to "____,"
        if (_word.Contains(',')) 
        {
            int wordLength = word.Length;
            for (int i = 1; i < wordLength; i++)
            {
                hiddenWord += "_";
            }
            hiddenWord += ",";
        }

        // Account for words that might be followed by a period, for example
        // so that _hiddenWord goes from "word." to "____."
        else if (_word.Contains('.')) 
        {
            int wordLength = word.Length;
            for (int i = 1; i < wordLength; i++)
            {
                hiddenWord += "_";
            }
            hiddenWord += ".";
        }

        // Regular word handling (no punctuation)
        else
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
        // Returns the mask's current status
        return _maskStatus;
    }

    public void SetMaskStatus(bool newStatus)
    {
        // Changes the mask's status to new boolean
        _maskStatus = newStatus;
    }

    public string GetWord()
    {
        // If mask is off, return regular _word
        if (_maskStatus == false)
        {
            return _word;
        }

        // If mask is on, return _hiddenWord
        else
        {
            return _hiddenWord;
        }
    }
}