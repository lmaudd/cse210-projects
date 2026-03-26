using System;

public abstract class Goal
{
    private string _goal;
    private int _pointValue;
    private bool _goalStatus;

    public Goal(string goal, int pointValue)
    {
        _goal = goal;
        _pointValue = pointValue;
        _goalStatus = false;
    }

    public void SetStatus(bool newStatus)
    {
        _goalStatus = newStatus;
    }

    public void SetPoints(int newPoints)
    {
        _pointValue = newPoints;
    }

    public abstract void RecordEvent();
}