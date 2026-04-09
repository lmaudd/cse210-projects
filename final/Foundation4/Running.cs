using System;

public class Running : Activity
{
    // Attributes
    private float _distance; // Distance in miles

    // Constructor
    public Running(string date, float length, float distance) : base(date, length)
    {
        _distance = distance;
    }
    
    // Methods
    public override float GetDistance()
    {
        return _distance; // in miles
    }

    public override string GetActivity()
    {
        return "Running";
    }
}