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
        bool isComplete = GetIsComplete();
        if (isComplete == true)
        {
            int completionPoints = GetCompletionPoints();
            return completionPoints;
        }

        return 0;
    }

    public override void DisplayGoal(int n)
    {   
        bool isComplete = GetIsComplete();
        string checkMark = " ";

        if (isComplete == true)
        {
            checkMark = "X";
        }

        string goal = GetGoal();
        string goalDescription = GetGoalDescription();
        string line = $"  {n}. [{checkMark}] {goal} ({goalDescription})";
        Console.WriteLine(line);
    }

    public override string GetStringRepresentation()
    {
        string writeGoal = GetGoal();
        string writeGoalDescription = GetGoalDescription();
        bool writeIsComplete = GetIsComplete();
        int writeGetCompletionPoints = GetCompletionPoints();

        return $"SG:{writeGoal},{writeGoalDescription},{writeIsComplete},{writeGetCompletionPoints}";
    }

    public override void CreateGoal(string StringRepresentation)
    {
        string[] parts = StringRepresentation.Split(",");
        
        string newGoal = parts[0];
        string newGoalDescription = parts[1];
        string newIsComplete = parts[2];
        int newCompletionPoints = Int32.Parse(parts[3]);

        SetGoal(newGoal);
        SetGoalDescription(newGoalDescription);
        SetCompletionPoints(newCompletionPoints);

        if (newIsComplete == "True")
        {
            SetIsComplete(true);
        }
        else
        {
            SetIsComplete(false);
        }
    }
}