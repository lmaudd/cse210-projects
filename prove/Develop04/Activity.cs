// https://numerics.net/documentation/latest/reference/numerics.net.curves.surfaces.gridboundarycondition.periodic
// https://stackoverflow.com/questions/5788883/how-can-i-convert-a-datetime-to-an-int
// https://learn.microsoft.com/en-us/dotnet/api/system.datetime.ticks?view=net-10.0
// https://stackoverflow.com/questions/858904/can-i-convert-long-to-int

using System;
using System.Dynamic;
using System.Xml.Serialization;

class Activity
{
    // Attributes
    private string _name; // Activity Name
    private string _description; // Description of activity

    // Constructor
    public Activity()
    {
    }

    // Setters for Constructor Help
    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    // Start & Finish Messages
    public void StartingMessage()
    {
        Console.WriteLine($"\nWelcome to the {_name}.");
        Console.WriteLine($"\n{_description}");
    }

    public void EndingMessage(int duration) 
    {
        Console.WriteLine($"\nYou have completed another {duration} seconds of {_name}.\n");
    }

    // Inquire about the time
    public int InquireTime() 
    {
        Console.Write("\nIn seconds, how long would you like your session to be? ");
        string userInput = Console.ReadLine();
        int durationSeconds = Int32.Parse(userInput);
        return durationSeconds;
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

    public float CalculateTimeChange(DateTime startTime, DateTime endTime)
    {   
        int difference = (int)startTime.Ticks - (int)endTime.Ticks;
        int seconds = difference * 10^-7;
        return seconds;
    }
}