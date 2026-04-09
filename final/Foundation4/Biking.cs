using System;

public class Biking : Activity
{
    // Attributes
    private float _speed;

    // Constructor
    public Biking(string date, float length) : base(date, length)
    {
        // figure out what to do with speed...
    }
    
    // Methods
    public override float GetDistance()
    {
        float length = GetLength();
        float distance = (_speed / 60) * length;
        return distance;
    }

    public override float GetSpeed()
    {
        return _speed;
    }

    public override float GetPace()
    {
        float speed = GetSpeed();
        float pace = 60 / speed;
        return pace;
    }
}