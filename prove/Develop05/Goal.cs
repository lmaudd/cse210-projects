using System;

public abstract class Goal
{
    // Member variables
    private string _goal;
    private int _pointValue;
    private bool _goalStatus;

    // Constructor
    public Goal(string goal, int pointValue)
    {
        _goal = goal;
        _pointValue = pointValue;
        _goalStatus = false;
    }

    // Getters & Setters
    public void SetStatus(bool newStatus)
    {
        _goalStatus = newStatus;
    }

    public void SetPoints(int newPoints)
    {
        _pointValue = newPoints;
    }

    // Other Methods
    public abstract void RecordEvent();

    public abstract int GetTotalPoints();
}