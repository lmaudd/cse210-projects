using System;

public abstract class Goal
{
    // Member variables ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    private string _goal;
    private int _completionPoints;
    private bool _isComplete;
    private string _goalDescription;

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
    public bool GetIsComplete()
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

    // Get & Set _goal ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    public string GetGoal()
    {
        return _goal;
    }

    public void SetGoal(string newGoal)
    {
        _goal = newGoal;
    }

    // Get & Set _goalDescription ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    public string GetGoalDescription()
    {
        return _goalDescription;
    }

    public void SetGoalDescription(string newGoalDescription)
    {
        _goalDescription = newGoalDescription;
    }
}