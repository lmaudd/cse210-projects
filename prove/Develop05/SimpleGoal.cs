using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string goal, int pointValue) : base(goal, pointValue){}

    public override void RecordEvent()
    {
        SetStatus(true);
    }
}