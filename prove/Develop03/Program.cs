// learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number
// https://ironpdf.com/blog/net-help/csharp-wait-for-seconds/

// Going above and beyond: I added a menu interface that allows the user to choose from a handful of scriptures. 
// The user can also add to the '.txt' file if they want more scriptures. 
//
// Furthermore, my program only hides uhidden words.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Preload default scripture
        string text = "Thus saith the LORD to his anointed, to Cyrus, whose right hand I have holden, to subdue nations before him; and I will loose the loins of kings, to open before him the two leaved gates; and the gates shall not be shut.";
        string reference = "Isaiah 45:1";

        // Instantiate classes
        Scripture scripture = new Scripture(text, reference);
        HelperFunctions hf = new HelperFunctions();

        // Simulation loop
        int userInput = -1;  // Value to store the user's response. Preloaded to -1.
        while (true)
        {
            // Menu work
            hf.Menu();                     // Display custom menu
            scripture.DisplayScripture();  // Print scripture to console
            userInput = hf.UserInquire();  // Ask the user for input
            scripture.HideWord();          // Hide a word (intentionally after display)

            // Menu Option: Load a scripture if user types '1'
            if (userInput == 1) // Load Scripture
            {
                (text, reference) = hf.Load();               // Load and save new scripture and reference
                scripture = new Scripture(text, reference);  // Update the scripture class with new info
            }

            // Menu Option: Quit application if user types '9'
            if (userInput == 9)
            {
                hf.Quit();  // Handles quitting the loop and thanking user
                break;      // Break the loop
            }

            // Menu Option Note: The loop continues otherwise. Technically, they can type
            // any number beside 1 or 9 will proceed to hide a word. I wish it could still 
            // be enter, but enter can't be cast to integer.

            // Completion Check
            if (scripture.CompletionCheck() == true)
            {
                hf.Menu();                     // Display custom menu
                scripture.DisplayScripture();  // Print scripture to console
                Console.WriteLine(" ");
                hf.Quit();                     // Handles quitting the loop and thanking user
                break;                         // Break the loop
            }
        }
    }
}