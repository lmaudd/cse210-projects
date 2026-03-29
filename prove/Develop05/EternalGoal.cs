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
        return GetCompletionPoints() * _timesCompleted;
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
        return $"EG:{GetGoal()},{GetGoalDescription()},{_timesCompleted},{GetCompletionPoints()}";
    }

    public override void CreateGoal(string StringRepresentation)
    {
        string[] parts = StringRepresentation.Split(",");

        SetGoal(parts[0]);
        SetGoalDescription(parts[1]);
        _timesCompleted = Int32.Parse(parts[2]);
        SetCompletionPoints(Int32.Parse(parts[3]));
    }
}