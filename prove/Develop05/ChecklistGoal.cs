using System;

public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _timesCompleted;
    private int _goalCompleted;

    public ChecklistGoal(int bonusPoints, int goalCompleted, string goal, int pointValue) : base(goal, pointValue)
    {
        _bonusPoints = bonusPoints;
        _timesCompleted = 0;
        _goalCompleted = goalCompleted;
    }

    public override void RecordEvent()
    {
        // Code here...
    }

    public override int GetTotalPoints()
    {
        // Code here ...
        return 1;
    }
}