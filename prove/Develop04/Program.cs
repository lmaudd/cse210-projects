using System;

class Program
{
    static void Main(string[] args)
    {
        // Define User Input Variables
        string menuOption = "";

        // Program Running Loop
        while (menuOption != "4")
        {
            // Get total points & show first menu
            menuOption = MenuInquiry();

            // Main Loop
            switch(menuOption)
            {
                case "1": // User has selected breathing activity
                    Breathing ba = new Breathing(); // Instantiate breathing class
                    ba.BreathingActivity(); // Execute activity
                    break;

                case "2": // User has selected reflection activity
                    Reflection ra = new Reflection(); // Instantiate reflection class
                    ra.ReflectionActivity();  // Execute activity
                    break;

                case "3": // User has selected listing activity
                    Listing la = new Listing(); // Instantiate listing class
                    la.ListingActivity();  // Execute activity
                    break;

                case "4": // User has selected "Quit"
                    Console.WriteLine("Thank you for using.\n");
                    break;
                
                default: // User has given invalid input
                    Console.WriteLine("~~ Invalid User Input ~~");
                    Console.ReadLine();
                    break;
            }        
        }
    }

    static string MenuInquiry()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Start breathing activity  ");
        Console.WriteLine("  2. Start reflection activity ");
        Console.WriteLine("  3. Start listing activity    ");
        Console.WriteLine("  4. Quit                      ");    
        Console.Write($"\nSelect a choice from the menu:  ");   
        return Console.ReadLine();
    }
}