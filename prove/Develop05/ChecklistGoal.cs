using System;

public class ChecklistGoal : Goal
{
    // Member Variables ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    private int _timesCompleted;
    private int _goalCompleted;
    private int _bonusPoints;

    // Constructor
    public ChecklistGoal(int bonusPoints, int goalCompleted, string goal, string goalDescription, int pointValue) : base(goal, goalDescription, pointValue)
    {
        _goalCompleted = goalCompleted;
        _bonusPoints = bonusPoints;
        _timesCompleted = 0;    
    }

    // Methods ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    public override void RecordEvent()
    {
        // If they haven't completed, iterate
        if (_timesCompleted < _goalCompleted)
        {
            _timesCompleted++;
        }

        // If they've done enough events, set true
        if (_timesCompleted == _goalCompleted)
        {
            SetIsComplete(true);
        }
    }

    public override int GetTotalPoints()
    {
        // Add points for each completion event
        int points = 0;
        points += GetCompletionPoints() * _timesCompleted;

        // Add bonus points if completed enough times
        if (GetIsComplete() == true)
        {
            points += _bonusPoints;
        }

        return points;
    }

    public override void DisplayGoal(int n)
    {   
        string checkMark = " ";

        if (GetIsComplete() == true)
        {
            checkMark = "X";
        }

        string line = $"  {n}. [{checkMark}] {GetGoal()} ({GetGoalDescription()}) {_timesCompleted}/{_goalCompleted}";
        Console.WriteLine(line);
    }

    public override string GetStringRepresentation()
    {
        return $"CG:{GetGoal()},{GetGoalDescription()},{GetIsComplete()},{GetCompletionPoints()}, {_timesCompleted}, {_goalCompleted}, {_bonusPoints}";
    }

    public override void CreateGoal(string StringRepresentation)
    {
        string[] parts = StringRepresentation.Split(",");

        SetGoal(parts[0]);
        SetGoalDescription(parts[1]);
        SetCompletionPoints(Int32.Parse(parts[3]));
        _timesCompleted = Int32.Parse(parts[4]);
        _goalCompleted = Int32.Parse(parts[5]);
        _bonusPoints = Int32.Parse(parts[6]);

        string boolean =  parts[2];

        if (boolean == "true")
        {
            SetIsComplete(true);
        }
        else
        {
            SetIsComplete(false);
        }
    }
}