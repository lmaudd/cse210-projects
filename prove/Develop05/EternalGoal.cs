using System;

public class EternalGoal : Goal
{
    public EternalGoal(string goal) : base(goal){}

    public override int RecordEvent()
    {
        // Code here...
        return 1;
    }
}