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
        Console.WriteLine("\nWell done!");
        Spinner(3); 
        Console.WriteLine($"\nYou have completed another {duration} seconds of {_name}.\n");
        Spinner(3); 
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
        while (timeSeconds > -1) // -1 to display 0
        {
            Console.Write(timeSeconds); // Write time
            Thread.Sleep(1000); // Wait one second
            Console.Write("\b \b"); // Erase time
            timeSeconds--; // Decrease time by the second elapsed
        }
    }

    public void PressEnter()
    {
        Console.ReadLine();
        Console.WriteLine();
    }

    public int CalculateTimeChange(DateTime startTime, DateTime endTime)
    {   
        int difference = (int)endTime.Ticks - (int)startTime.Ticks; // Calculate difference in ticks
        double seconds = difference * 0.0000001; // Convert ticks (100 nanoseconds) to seconds
        int secondsInt = (int)seconds; // Convert to int (precision here isn't needed and this will simplify comparisons
        return secondsInt;
    }
}