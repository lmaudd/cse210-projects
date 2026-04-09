using System;

public class Running : Activity
{
    // Attributes
    private float _distance;

    // Constructor
    public Running(string date, float length, float distance) : (date, length)
    {
        _distance = distance;
    }
    
    // Methods
    public override float GetDistance()
    {
        return _distance;
    }

    public override float GetSpeed()
    {
        float length = GetLength();
        float speed = 1;
        return speed;
    }

    public override float GetPace()
    {
        
    }
}