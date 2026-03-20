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

    public void PauseAnimation(int timeSeconds) 
    {
        List<char> temp = new List<char> {'|', '/', '-', '\\', '|', '/', '-', '\\', 
                                          '|', '/', '-', '\\', '|', '/', '-', '\\',
                                          '|', '/', '-', '\\', '|', '/', '-', '\\',
                                          '|', '/', '-', '\\', '|', '/', '-', '\\',
                                          '|', '/', '-', '\\', '|', '/', '-', '\\',
                                          '|', '/', '-', '\\', '|', '/', '-', '\\',
                                          '|', '/', '-', '\\', '|', '/', '-', '\\', '|'};

        for (int i = timeSeconds; i > 0; i--)
        {
            Console.Write(temp[i]);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
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