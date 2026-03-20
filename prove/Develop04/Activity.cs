using System;

class Activity
{
    // Attributes
    public string _activityName;
    protected int _duration;

    // Methods
    public Activity(string activityName)
    {
        _activityName = activityName;
        _duration = -1;
    }

    public void StartingMessage()
    {
        Console.WriteLine($"\nWelcome to the {_activityName}.");
    }

    public void EndingMessage() 
    {
        Console.WriteLine($"\nYou have completed another {_duration} seconds of {_activityName}.\n");
    }

    public void PauseTime(double time) 
    {

    }

    public void InquireTime() 
    {
        Console.Write("\nIn seconds, how long would you like your session to be? ");
        string userInput = Console.ReadLine();
        int durationSeconds = Int32.Parse(userInput);
        _duration = durationSeconds;
    }

    public int GetDuration() 
    {
        return _duration;
    }

    public bool CheckTime() 
    {
        return true;
    }
}