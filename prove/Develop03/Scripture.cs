using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

class Scripture
{
    // Class attributes
    private Reference _reference;
    private List<Word> _scripture;
    private List<int> _hiddenVerses;

    // Class constructor
    public Scripture(string scripture, string reference)
    {
        // _reference = GenerateReferenceList(reference);
        // _scripture = GenerateWordList(scripture);
        _hiddenVerses = new List<int>();

    }

    // Class set-up methods
    // https://learn.microsoft.com/en-us/dotnet/api/system.string.split?view=net-10.0
    // private List<Word> GenerateWordList(string scripture)
    // {
    
    // }

    // private Reference GenerateReferenceList(string reference)
    // {
        
    // }

    // Class methods
    public void HideWord()
    // https://stackoverflow.com/questions/17381332/how-to-tell-if-a-list-does-not-contain-an-element
    {
        int length = _scripture.Count();
        Random random = new Random();
        int newIndex = -1;

        while (true)
        {
            if (_hiddenVerses.Count() == _scripture.Count())
            {
                break;
            }
            
            newIndex = random.Next(length);

            if (!_hiddenVerses.Contains(newIndex))
            {
                _hiddenVerses.Add(newIndex);
                break;
            }
        }
    }

    public void Print()
    {
        foreach (int number in _hiddenVerses)
        {
            Console.WriteLine(number);
        }
    }

    public void DisplayScripture()
    {

    }
}