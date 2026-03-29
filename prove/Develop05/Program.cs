// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/exception-handling-statementsusing System;
// https://www.w3schools.com/cs/cs_switch.php

using System.IO.Compression;
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
            // Get total points & show first menu
            int points = SumPoints(goals);
            mainOption = MainMenuInquiry(points);

            // Main Loop
            switch(mainOption)
            {
                case "1": // User has selected "Create New Goal"
                    goalOption = GoalMenuInquiry();
                    
                    switch (goalOption)
                    {
                        case "1": // User has selected "Simple Goal"
                            // Obtain Goal
                            Console.Write("  - What is the name of your goal? ");
                            string sGoal = Console.ReadLine();

                            // Obtain Goal Description
                            Console.Write("  - Describe your goal... ");
                            string sGoalDescription = Console.ReadLine();

                            // Obtain Goal Point Value (for completion)
                            Console.Write("  - How many points is completing this goal worth? ");
                            string sPointValueString = Console.ReadLine();
                            int sPointValue = Int32.Parse(sPointValueString);

                            // Instantiate Goal, Save to List, & Break
                            SimpleGoal sg = new SimpleGoal(sGoal, sGoalDescription, sPointValue);
                            goals.Add(sg);
                            break;

                        case "2": // User has selected "Eternal Goal"
                            // Obtain Goal
                            Console.Write("  - What is the name of your goal? ");
                            string eGoal = Console.ReadLine();

                            // Obtain Goal Description
                            Console.Write("  - Describe your goal... ");
                            string eGoalDescription = Console.ReadLine();

                            // Obtain Goal Point Value (for completion)
                            Console.Write("  - How many points is completing this goal worth? ");
                            string ePointValueString = Console.ReadLine();
                            int ePointValue = Int32.Parse(ePointValueString);

                            // Instantiate Goal, Save to List, & Break
                            EternalGoal eg = new EternalGoal(eGoal, eGoalDescription, ePointValue);
                            goals.Add(eg);
                            break;

                        case "3": // User has selected "Checklist Goal"
                            // Obtain Goal
                            Console.Write("  - What is the name of your goal? ");
                            string cGoal = Console.ReadLine();

                            // Obtain Goal Description
                            Console.Write("  - Describe your goal... ");
                            string cGoalDescription = Console.ReadLine();

                            // Obtain Goal Point Value (for completion)
                            Console.Write("  - How many points is completing this goal worth? ");
                            string cPointValueString = Console.ReadLine();
                            int cPointValue = Int32.Parse(cPointValueString);

                            // Obtain Times Goal Should be Completed
                            Console.Write("  - How times would you like to complete this goal? ");
                            string cGoalCompletedString = Console.ReadLine();
                            int cGoalCompleted = Int32.Parse(cGoalCompletedString);

                            // Obtain Bonus Point Value (for completing n times)
                            Console.Write($"  - How many points should you get for completing the goal {cGoalCompleted} times? ");
                            string cBonusPointsString = Console.ReadLine();
                            int cBonusPoints = Int32.Parse(cBonusPointsString);

                            // Instantiate Goal, Save to List, & Break
                            ChecklistGoal cg = new ChecklistGoal(cBonusPoints, cGoalCompleted, cGoal, cGoalDescription, cPointValue);
                            goals.Add(cg);
                            break;

                        default: // User has given invalid input
                            Console.WriteLine("~~ Invalid User Input ~~");
                            Console.ReadLine();
                            break;
                    }

                    break;

                case "2": // User has selected "List Goals"
                    ListGoals(goals);
                    Console.ReadLine(); // Wait for enter to close
                    break;

                case "3": // User has selected "Save Goals"
                    using (StreamWriter outputFile = new StreamWriter("goalFile.txt"))
                    {
                        foreach (Goal goal in goals)
                        {
                            outputFile.WriteLine(goal.GetStringRepresentation());
                        }
                    }
                    break;

                case "4": // User has selected "Load Goals"
                    string[] lines = System.IO.File.ReadAllLines("goalFile.txt");

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(":");

                        string goalType = parts[0];
                        string StringRepresentation = parts[1];

                        switch (goalType)
                        {
                            case "SG":
                                SimpleGoal sg = new SimpleGoal("", "", -1);
                                sg.CreateGoal(StringRepresentation);
                                goals.Add(sg);
                                break;
                            
                            case "EG":
                                EternalGoal eg = new EternalGoal("", "", -1);
                                eg.CreateGoal(StringRepresentation);
                                goals.Add(eg);
                                break;

                            case "CG":
                                ChecklistGoal cg = new ChecklistGoal(-1, -1, "", "", -1);
                                cg.CreateGoal(StringRepresentation);
                                goals.Add(cg);
                                break;
                        }
                    }
                    break;

                case "5": // User has selected "Record Event"
                    // Obtain the index of the event to record
                    ListGoals(goals);
                    Console.Write($"\nWhich event would you like to record? ");
                    string eventString = Console.ReadLine();
                    int eventIndex = Int32.Parse(eventString) - 1; // Decrease by one to account for 0 indexing

                    // Record Event
                    try
                    {
                        goals[eventIndex].RecordEvent();
                        int pointValue = goals[eventIndex].GetTotalPoints();
                        Console.WriteLine($"Congratualtions! This goal has accumulated you {pointValue} points!");
                        Console.ReadLine();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("~~ Invalid User Input ~~");
                        Console.ReadLine();
                    }
                    
                    break;

                case "6": // User has selected "Quit"
                    Console.WriteLine("Thank you for using Eternal Quest.\n");
                    break;
                
                default: // User has given invalid input
                    Console.WriteLine("~~ Invalid User Input ~~");
                    Console.ReadLine();
                    break;
            }        
        }
    }

    static void ListGoals(List<Goal> goals)
    {
        int n = 1;
        foreach (Goal g in goals)
        {
            g.DisplayGoal(n);
            n++;
        }
    }

    static int SumPoints(List<Goal> goals)
    {
        int points = 0;

        foreach (Goal g in goals)
        {
            points += g.GetTotalPoints();
        }

        return points;
    }

    static string MainMenuInquiry(int points)
    {
        Console.Clear();
        Console.WriteLine($"\nPoints: {points}\n");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal ");
        Console.WriteLine("  2. List Goals      ");
        Console.WriteLine("  3. Save Goals      ");
        Console.WriteLine("  4. Load Goals      ");
        Console.WriteLine("  5. Record Event    ");  
        Console.WriteLine("  6. Quit            ");    
        Console.Write($"\nSelect a choice from the menu: ");   
        return Console.ReadLine();
    }

    static string GoalMenuInquiry()
    {
        Console.WriteLine("\nThe types of goals are...");
        Console.WriteLine("  1. Simple Goal    ");
        Console.WriteLine("  2. Eternal Goal   ");
        Console.WriteLine("  3. Checklist Goal ");  
        Console.Write($"\nSelect a choice from the menu: ");   
        return Console.ReadLine();
    }
}