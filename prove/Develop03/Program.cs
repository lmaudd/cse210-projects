using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");

        string text = "Thus saith the LORD to his anointed, to Cyrus, whose right hand I have holden, to subdue nations before him; and I will loose the loins of kings, to open before him the two leaved gates; and the gates shall not be shut.";
        string reference = "Isaiah 45:1";

        Scripture scripture = new Scripture(text, reference);
        scripture.DisplayScripture();
    }
}