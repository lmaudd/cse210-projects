using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // Initialize Eternal Quest Variables
        List<Goal> goals = new List<Goal>();

        // Define User Input Variables
        string mainOption = "";
        string goalOption = "";

        // Program Running Loop
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
                            // Obtain Goal
                            Console.Write("What is the name of your goal? ");
                            string sGoal = Console.ReadLine();

                            // Obtain Goal Description
                            Console.Write("Describe your goal... ");
                            string sGoalDescription = Console.ReadLine();

                            // Obtain Goal Point Value (for completion)
                            Console.Write("How many points is completing this goal worth? ");
                            string sPointValueString = Console.ReadLine();
                            int sPointValue = Int32.Parse(sPointValueString);

                            // Instantiate Goal, Save to List, & Break
                            SimpleGoal sg = new SimpleGoal(sGoal, sGoalDescription, sPointValue);
                            goals.Add(sg);
                            break;

                        case "2": // User has selected "Eternal Goal"
                            // Obtain Goal
                            Console.Write("What is the name of your goal? ");
                            string eGoal = Console.ReadLine();

                            // Obtain Goal Description
                            Console.Write("Describe your goal... ");
                            string eGoalDescription = Console.ReadLine();

                            // Obtain Goal Point Value (for completion)
                            Console.Write("How many points is completing this goal worth? ");
                            string ePointValueString = Console.ReadLine();
                            int ePointValue = Int32.Parse(ePointValueString);

                            // Instantiate Goal, Save to List, & Break
                            EternalGoal eg = new EternalGoal(eGoal, eGoalDescription, ePointValue);
                            goals.Add(eg);
                            break;

                        case "3": // User has selected "Checklist Goal"
                            // Obtain Goal
                            Console.Write("What is the name of your goal? ");
                            string cGoal = Console.ReadLine();

                            // Obtain Goal Description
                            Console.Write("Describe your goal... ");
                            string cGoalDescription = Console.ReadLine();

                            // Obtain Goal Point Value (for completion)
                            Console.Write("How many points is completing this goal worth? ");
                            string cPointValueString = Console.ReadLine();
                            int cPointValue = Int32.Parse(cPointValueString);

                            // Instantiate Goal, Save to List, & Break
                            EternalGoal cg = new EternalGoal(cGoal, cGoalDescription, cPointValue);
                            goals.Add(cg);
                            break;

                        default: // User has given invalid input
                            Console.WriteLine("~~ Invalid User Input ~~");
                            break;
                    }

                    break;

                case "2": // User has selected "List Goals"
                    int n = 1;
                    foreach (Goal g in goals)
                    {
                        g.DisplayGoal(n);
                        n++;
                    }
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
        Console.Clear();
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
        Console.WriteLine("");
        Console.WriteLine("The types of goals are...");
        Console.WriteLine("  1. Simple Goal    ");
        Console.WriteLine("  2. Eternal Goal   ");
        Console.WriteLine("  3. Checklist Goal ");  
        Console.Write("Select a choice from the menu: ");   
        return Console.ReadLine();
    }
}