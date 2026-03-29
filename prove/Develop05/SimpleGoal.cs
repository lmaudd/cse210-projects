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
        SetIsComplete(true);
    }

    public override int GetTotalPoints()
    {
        if (GetIsComplete() == true)
        {
            return GetCompletionPoints();
        }

        return 0;
    }

    public override void DisplayGoal(int n)
    {   
        string checkMark = " ";

        if (GetIsComplete() == true)
        {
            checkMark = "X";
        }

        string line = $"  {n}. [{checkMark}] {GetGoal()} ({GetGoalDescription()})";
        Console.WriteLine(line);
    }

    public override string GetStringRepresentation()
    {
        return $"SG:{GetGoal()},{GetGoalDescription},{GetIsComplete},{GetCompletionPoints}";
    }

    public override void CreateGoal(string StringRepresentation)
    {
        string[] parts = StringRepresentation.Split(",");

        SetGoal(parts[0]);
        SetGoalDescription(parts[1]);
        SetCompletionPoints(Int32.Parse(parts[3]));

        SetGoal(parts[0]);

        string boolean =  parts[2];

        if (boolean == "true")
        {
            SetIsComplete(true);
        }
        else
        {
            SetIsComplete(false);
        }
    }
}