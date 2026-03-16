// learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number
// https://ironpdf.com/blog/net-help/csharp-wait-for-seconds/

using System;

class Program
{
    static void Main(string[] args)
    {
        string text = "Thus saith the LORD to his anointed, to Cyrus, whose right hand I have holden, to subdue nations before him; and I will loose the loins of kings, to open before him the two leaved gates; and the gates shall not be shut.";
        string reference = "Isaiah 45:1";

        Scripture scripture = new Scripture(text, reference);
        HelperFunctions hf = new HelperFunctions();

        int userInput = -1;

        while (true)
        {
            hf.Menu();
            scripture.DisplayScripture();
            userInput = hf.UserInquire();

            if (userInput == 9) // Quit application
            {
                hf.Quit();
                break;
            }

            scripture.HideWord();

            if (userInput == 1) // Load Scripture
            {
                (text, reference) = hf.Load();
                scripture = new Scripture(text, reference);
            }
        }
    }
}