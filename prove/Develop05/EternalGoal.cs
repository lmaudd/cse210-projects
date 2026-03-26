using System;

public class EternalGoal : Goal
{
    private int _timesCompleted;

    public EternalGoal(string goal, int pointValue) : base(goal, pointValue)
    {
        _timesCompleted = 0;
    }

    public override void RecordEvent()
    {
        _timesCompleted++;
    }
    public override int GetTotalPoints()
    {
        // Code here ...
        return 1;
    }
}