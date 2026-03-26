using System;

public abstract class Goal
{
    // Member variables
    private int _completionPoints;
    private bool _goalStatus;
    private string _goal;

    // Constructor
    public Goal(string goal, int completionPoints)
    {
        _completionPoints = completionPoints;
        _goalStatus = false;
        _goal = goal;   
    }

    // Get & Set Status
    public bool GetStatus()
    {
        return _goalStatus;
    }
        
    public void SetStatus(bool newStatus)
    {
        _goalStatus = newStatus;
    }

    // Get & Set Completion Points
    public int GetCompletionPoints()
    {
        return _completionPoints;
    }

    public void SetCompletionPoints(int newPoints)
    {
        _completionPoints = newPoints;
    }

    // Other Methods (Abstract)
    public abstract void RecordEvent();

    public abstract int GetTotalPoints();
}