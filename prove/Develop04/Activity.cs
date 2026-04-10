// https://numerics.net/documentation/latest/reference/numerics.net.curves.surfaces.gridboundarycondition.periodic

using System;
using System.Xml.Serialization;

class Activity
{
    // Attributes ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    private string _name; // Activity Name
    private string _description; // Description of activity
    private int _duration; // User chosen duration

    // Constructor ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = -1;
    }

    // Start & Finish Messages ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    public void StartingMessage()
    {
        Console.WriteLine($"\nWelcome to the {_name}.");
    }

    public void EndingMessage() 
    {
        Console.WriteLine($"\nYou have completed another {_duration} seconds of {_name}.\n");
    }

    // Inquire about the time ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    public void InquireTime() 
    {
        Console.Write("\nIn seconds, how long would you like your session to be? ");
        string userInput = Console.ReadLine();
        int durationSeconds = Int32.Parse(userInput);
        _duration = durationSeconds;
    }

    // Activity Timers, Spinners ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    public void Spinner(int timeSeconds) 
    {
        List<char> temp = new List<char> {'|', '/', '-', '\\'};

        for (int i = timeSeconds; i > 0; i--)
        {
            int index = ((i % 4) + 4) % 4; // periodic boundary conditions that I learned in Physics 385, numerical modelling physics
            Console.Write(temp[index]);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void CountDown(int timeSeconds)
    {
        // Right code here...
    }

    public void PressEnter()
    {
        Console.Write("\n Press enter continue: ");
        Console.ReadLine();
        Console.WriteLine();
    }
}