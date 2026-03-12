using System;

class Program
{
    static void Main(string[] args)
    {
        string text = "Thus saith the LORD to his anointed, to Cyrus, whose right hand I have holden, to subdue nations before him; and I will loose the loins of kings, to open before him the two leaved gates; and the gates shall not be shut.";
        string reference = "Isaiah 45:1";

        Scripture scripture = new Scripture(text, reference);

        string cont = "";

        while (cont != "quit")
        {
            Console.Clear();
            Console.WriteLine(" ");
            scripture.DisplayScripture();

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.Write("Type 'quit' to quit: ");
            cont = Console.ReadLine();
            scripture.HideWord();
            Console.WriteLine(" ");
        }
    }
}