// https://learn.microsoft.com/en-us/dotnet/api/system.string.split?view=net-10.0
// https://stackoverflow.com/questions/17381332/how-to-tell-if-a-list-does-not-contain-an-element

using System;

class Scripture
{
    // Class attributes ///////////////////////////////////////////////////////////////////////
    private Reference _reference;
    private List<Word> _scripture;

    // Class constructor ///////////////////////////////////////////////////////////////////////
    public Scripture(string scripture, string reference)
    {
        _reference = GenerateReferenceList(reference);
        _scripture = GenerateWordList(scripture);
    }

    // Class set-up methods ////////////////////////////////////////////////////////////////////
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

    // Class methods ///////////////////////////////////////////////////////////////////////////
    public void HideWord()
    {
        Random random = new Random();
        int length = _scripture.Count();
        int maxIterations = length + 5; // This many iterations will always be sufficient
        int newIndex = -1;

        // Hide first of three words
        for (int i = 0; i < maxIterations; i++) 
        {        
            newIndex = random.Next(length);

            if (_scripture[newIndex].GetMaskStatus() ==  false)
            {
                _scripture[newIndex].SetMaskStatus(true);
                break;
            }
        }

        // Hide second of three words
        for (int i = 0; i < maxIterations; i++) 
        {        
            newIndex = random.Next(length);

            if (_scripture[newIndex].GetMaskStatus() ==  false)
            {
                _scripture[newIndex].SetMaskStatus(true);
                break;
            }
        }

        // Hide third of three words
        for (int i = 0; i < maxIterations; i++) 
        {        
            newIndex = random.Next(length);

            if (_scripture[newIndex].GetMaskStatus() ==  false)
            {
                _scripture[newIndex].SetMaskStatus(true);
                break;
            }
        }
    }

    public void DisplayScripture()
    {
        string r = _reference.GetReference();
        Console.Write($"{r}  ");

        foreach (Word item in _scripture)
        {
            Console.Write($"{item.GetWord()} ");
        }
    }

    public bool CompletionCheck()
    {
        // Determine whether or not scripture is done
        int totalCount = _scripture.Count();
        int hiddenCount = 0;

        foreach (Word item in _scripture)
        {
            if (item.GetMaskStatus() == true)
            {
                hiddenCount++;
            }
        }

        if (hiddenCount == totalCount)
        {
            return true;
        }

        else
        {
            return false;
        }
    }
}