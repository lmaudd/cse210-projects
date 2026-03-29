using System;

public class EternalGoal : Goal
{
    // Member Variables ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    private int _timesCompleted;

    // Constructor ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    public EternalGoal(string goal, string goalDescription, int pointValue) : base(goal, goalDescription, pointValue)
    {
        _timesCompleted = 0;
    }

    // Methods ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
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
        bool isComplete = GetIsComplete();
        string goal = GetGoal();
        string goalDescription = GetGoalDescription();

        if (isComplete == true)
        {
            checkMark = "X";
        }

        string line = $"  {n}. [{checkMark}] {goal} ({goalDescription})";
        Console.WriteLine(line);
    }

    public override string GetStringRepresentation()
    {
        string goal = GetGoal();
        string goalDescription = GetGoalDescription();
        int completionPoints = GetCompletionPoints();

        return $"EG:{goal},{goalDescription},{_timesCompleted},{completionPoints}";
    }

    public override void CreateGoal(string StringRepresentation)
    {
        string[] parts = StringRepresentation.Split(",");
        
        string newGoal = parts[0];
        string newGoalDescription = parts[1];
        int newCompletionStatus = Int32.Parse(parts[3]);

        SetGoal(newGoal);
        SetGoalDescription(newGoalDescription);
        _timesCompleted = Int32.Parse(parts[2]);
        SetCompletionPoints(newCompletionStatus);
    }
}