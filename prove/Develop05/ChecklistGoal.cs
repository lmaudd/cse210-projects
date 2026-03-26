using System;

public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _timesCompleted;
    private int _goalCompleted;

    public ChecklistGoal(int bonusPoints, int timesCompleted, int goalCompleted, string goal) : base(goal)
    {
        _bonusPoints = bonusPoints;
        _timesCompleted = timesCompleted;
        _goalCompleted = goalCompleted;
    }

    public override int RecordEvent()
    {
        // Code here...
        return 1;
    }
}