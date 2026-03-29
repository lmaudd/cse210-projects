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
        int completionPoints = GetCompletionPoints();
        int points = 0;
        points += completionPoints * _timesCompleted;

        // Add bonus points if completed enough times
        bool isComplete = GetIsComplete();
        if (isComplete == true)
        {
            points += _bonusPoints;
        }

        return points;
    }

    public override void DisplayGoal(int n)
    {   
        string checkMark = " ";
        bool isComplete = GetIsComplete();
        string goal = GetGoal();
        string goalDescription = GetGoalDescription();

        if (isComplete == true)
        {
            checkMark = "X";
        }

        string line = $"  {n}. [{checkMark}] {goal} ({goalDescription}) {_timesCompleted}/{_goalCompleted}";
        Console.WriteLine(line);
    }

    public override string GetStringRepresentation()
    {
        string newGoal = GetGoal();
        string newGoalDescription = GetGoalDescription();
        bool newIsComplete = GetIsComplete();
        int newCompletionPoints = GetCompletionPoints();

        return $"CG:{newGoal},{newGoalDescription},{newIsComplete},{newCompletionPoints},{_timesCompleted},{_goalCompleted},{_bonusPoints}";
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

        if (boolean == "True")
        {
            SetIsComplete(true);
        }
        else
        {
            SetIsComplete(false);
        }
    }
}