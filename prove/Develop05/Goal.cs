using System;

public abstract class Goal
{
    // Member variables ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    protected string _goal;
    protected int _completionPoints;
    protected bool _isComplete;
    protected string _goalDescription;

    // Constructor ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    public Goal(string goal, string goalDescription, int completionPoints)
    {
        _completionPoints = completionPoints;
        _goalDescription = goalDescription;
        _isComplete = false;
        _goal = goal;   
    }

    // Abstract Methods ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    public abstract void RecordEvent(); // 

    public abstract int GetTotalPoints(); // 

    public abstract void DisplayGoal(int n); // 

    public abstract string GetStringRepresentation(); // 

    public abstract void CreateGoal(string StringRepresentation); // 

    // Get & Set _isComplete ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    public bool SetIsComplete()
    {
        return _isComplete;
    }
        
    public void SetIsComplete(bool newStatus)
    {
        _isComplete = newStatus;
    }

    // Get & Set _completionPoints ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    public int GetCompletionPoints()
    {
        return _completionPoints;
    }

    public void SetCompletionPoints(int newPoints)
    {
        _completionPoints = newPoints;
    }

    // Get _goal & _goalDescription ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    public string GetGoal()
    {
        return _goal;
    }

    public string GetGoalDescription()
    {
        return _goalDescription;
    }
}