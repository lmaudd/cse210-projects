using System;

public class EternalGoal : Goal
{
    // Member Variables
    private int _timesCompleted;

    // Constructor 
    public EternalGoal(string goal, int pointValue) : base(goal, pointValue)
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
}