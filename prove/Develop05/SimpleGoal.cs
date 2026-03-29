// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number

using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

public class SimpleGoal : Goal
{
    // Constructor ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    public SimpleGoal(string goal, string goalDescription, int pointValue) : base(goal, goalDescription, pointValue){}

    // Methods ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
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
        return $"SG:{_goal},{_goalDescription},{_isComplete},{_completionPoints}";
    }

    public override void CreateGoal(string StringRepresentation)
    {
        string[] parts = StringRepresentation.Split(",");

        _goal = parts[0];
        _goalDescription = parts[1];
        _completionPoints = Int32.Parse(parts[3]);

        string boolean =  parts[2];

        if (boolean == "true")
        {
            _isComplete = true;
        }

        else
        {
            _isComplete = false;
        }
    }
}