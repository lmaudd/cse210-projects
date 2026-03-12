using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");

        // string sentence = "Thus saith the LORD to his anointed, to Cyrus, whose right hand I have holden, to subdue nations before him; and I will loose the loins of kings, to open before him the two leaved gates; and the gates shall not be shut.";

        // string[] sentenceList = sentence.Split(" ");

        // foreach (string word in sentenceList)
        // {
        //     Console.WriteLine(word);
        // }

        Word word = new Word("Apple");
        word.Test();
    }
}