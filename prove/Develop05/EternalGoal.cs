using System;

public class EternalGoal : Goal
{
    // Member Variables
    private int _timesCompleted;

    // Constructor 
    public EternalGoal(string goal, string goalDescription, int pointValue) : base(goal, goalDescription, pointValue)
    {
        _timesCompleted = 0;
    }

    // Methods
    public override void RecordEvent()
    {
        _timesCompleted++;
    }
    
    public override int GetTotalPoints()
    {
        int completionPoints = GetCompletionPoints();
        return completionPoints * _timesCompleted;
    }

    public override void DisplayGoal(int n)
    {   
        string checkMark = " ";

        if (_isComplete == true)
        {
            checkMark = "X";
        }

        string line = $"  {n}. [{checkMark}] {_goal} ({_goalDescription})";
        Console.WriteLine(line);
    }
}