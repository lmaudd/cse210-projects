using System;

class Program
{
    static void Main(string[] args)
    {
        string mainOption = "";
        string goalOption = "";

        while (mainOption != "6")
        {
            mainOption = MainMenuInquiry();

            switch(mainOption)
            {
                case "1": // User has selected "Create New Goal"
                    goalOption = GoalMenuInquiry();
                    
                    switch (goalOption)
                    {
                        case "1": // User has selected "Simple Goal"
                            // Code to create simple goal...
                            break;

                        case "2": // User has selected "Eternal Goal"
                            // Code to create eternal goal...
                            break;

                        case "3": // User has selected "Checklist Goal"
                            // Code to create checklist goal...
                            break;

                        default: // User has given invalid input
                            Console.WriteLine("~~ Invalid User Input ~~");
                            break;

                    }

                    break;

                case "2": // User has selected "List Goals"
                    // Code to list goals...
                    break;

                case "3": // User has selected "Save Goals"
                    // Code to save goals
                    break;

                case "4": // User has selected "Load Goals"
                    // Code to load goals...
                    break;

                case "5": // User has selected "Record Event"
                    // Code to record an event...
                    break;

                case "6": // User has selected "Quit"
                    Console.WriteLine("Thank you for using.");
                    break;
                
                default: // User has given invalid input
                    Console.WriteLine("~~ Invalid User Input ~~");
                    break;
            }        
        }
    }

    static string MainMenuInquiry()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal ");
        Console.WriteLine("  2. List Goals      ");
        Console.WriteLine("  3. Save Goals      ");
        Console.WriteLine("  4. Load Goals      ");
        Console.WriteLine("  5. Record Event    ");  
        Console.WriteLine("  6. Quit            ");    
        Console.Write("Select a choice from the menu: ");   
        return Console.ReadLine();
    }

    static string GoalMenuInquiry()
    {
        Console.WriteLine("The types of goals are...");
        Console.WriteLine("  1. Simple Goal    ");
        Console.WriteLine("  2. Eternal Goal   ");
        Console.WriteLine("  3. Checklist Goal ");  
        Console.Write("Select a choice from the menu: ");   
        return Console.ReadLine();
    }
}