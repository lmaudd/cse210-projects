using System;

public class ChecklistGoal : Goal
{
    // Member Variables
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

    // Methods
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
            _isComplete = true;
        }
    }

    public override int GetTotalPoints()
    {
        // Add points for each completion event
        int points = 0;
        points += _completionPoints * _timesCompleted;

        // Add bonus points if completed enough times
        if (_isComplete == true)
        {
            points += _bonusPoints;
        }

        return points;
    }

    public override void DisplayGoal(int n)
    {   
        string checkMark = " ";

        if (_isComplete == true)
        {
            checkMark = "X";
        }

        string line = $"  {n}. [{checkMark}] {_goal} ({_goalDescription}) {_timesCompleted}/{_goalCompleted}";
        Console.WriteLine(line);
    }

    public override string GetStringRepresentation()
    {
        return $"CG:{_goal},{_goalDescription},{_isComplete},{_completionPoints}, {_timesCompleted}, {_goalCompleted}, {_bonusPoints}";
    }

    public override void CreateGoal(string StringRepresentation)
    {
        
    }
}