using System;

public abstract class Goal
{
    // Member variables
    private int _completionPoints;
    private bool _isComplete;
    private string _goal;

    // Constructor
    public Goal(string goal, int completionPoints)
    {
        _completionPoints = completionPoints;
        _isComplete = false;
        _goal = goal;   
    }

    // Get & Set Status
    public bool GetIsComplete()
    {
        return _isComplete;
    }
        
    public void SetIsComplete(bool newStatus)
    {
        _isComplete = newStatus;
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