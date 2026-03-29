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
        _isComplete = true;
    }

    public override int GetTotalPoints()
    {
        if (_isComplete == true)
        {
            return _completionPoints;
        }

        return 0;
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

    public override string GetStringRepresentation()
    {
        return "";
    }

    public override string CreateGoal()
    {
        return "";
    }
}