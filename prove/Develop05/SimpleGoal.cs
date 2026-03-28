using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

public class SimpleGoal : Goal
{
    // Constructor
    public SimpleGoal(string goal, string goalDescription, int pointValue) : base(goal, goalDescription, pointValue){}

    // Methods
    public override void RecordEvent()
    {
        SetIsComplete(true);
    }

    public override int GetTotalPoints()
    {
        bool status = GetIsComplete();
        int completionPoints = 0;

        if (status == true)
        {
            completionPoints = GetCompletionPoints();
        }

        return completionPoints;
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