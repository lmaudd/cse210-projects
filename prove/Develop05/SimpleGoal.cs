using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string goal) : base(goal){}

    public override int RecordEvent()
    {
        // Code here...
        return 1;
    }
}