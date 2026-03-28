using System;

public class SimpleGoal : Goal
{
    // Constructor
    public SimpleGoal(string goal, string goalDescription, int pointValue) : base(goal, goalDescription, pointValue){}

    // Methods
    public override void RecordEvent()
    {
        SetIsComplete(true);
    }

    public override int GetTotalPoints()
    {
        bool status = GetIsComplete();
        int completionPoints = 0;

        if (status == true)
        {
            completionPoints = GetCompletionPoints();
        }

        return completionPoints;
    }
}