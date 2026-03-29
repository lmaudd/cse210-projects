using System;

public abstract class Goal
{
    // Member variables
    protected int _completionPoints;
    protected bool _isComplete;
    protected string _goalDescription;
    protected string _goal;

    // Constructor
    public Goal(string goal, string goalDescription, int completionPoints)
    {
        _completionPoints = completionPoints;
        _goalDescription = goalDescription;
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

    public abstract void DisplayGoal(int n);

    // The Factory Pattern
    public abstract string GetStringRepresentation();
    public abstract string CreateGoal();
}