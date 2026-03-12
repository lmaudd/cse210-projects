using System;
using System.Collections.Concurrent;
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
        _reference = GenerateReferenceList(reference);
        _scripture = GenerateWordList(scripture);
        _hiddenVerses = new List<int>();

    }

    // Class set-up methods
    // https://learn.microsoft.com/en-us/dotnet/api/system.string.split?view=net-10.0
    private List<Word> GenerateWordList(string scripture)
    {
        List<Word> scriptureWordList = new List<Word>();
        string[] scriptureList = scripture.Split(" ");

        foreach (string item in scriptureList)
        {
            Word word = new Word(item);
            scriptureWordList.Add(word);
        }

        return scriptureWordList;
    }

    private Reference GenerateReferenceList(string reference)
    {
        Reference referenceWorking;
        string[] referenceList = reference.Split(' ', ':', '-'); // ensure char

        string book = referenceList[0];
        string chapter = referenceList[1];
        string verse = referenceList[2];

        if (reference.Contains('-'))
        {
            string verseEnd = referenceList[3];
            referenceWorking = new Reference(book, chapter, verse, verseEnd);
        }

        else 
        {
           referenceWorking = new Reference(book, chapter, verse);
        }

        return referenceWorking;
    }

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
        string r = _reference.GetReference();
        Console.Write($"{r}  ");

        int i = 0;
        foreach (Word item in _scripture)
        {
            if (_hiddenVerses.Contains(i)) // mask
            {
                Console.Write($"{item.GetWord(true)} ");
            }

            else // don't mask
            {
                Console.Write($"{item.GetWord(false)} "); 
            }

            i++;
        }
    }
}