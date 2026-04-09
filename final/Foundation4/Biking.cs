using System;

public class Biking : Activity
{
    // Attributes
    private float _speed;

    // Constructor
    public Biking(string date, float length, float speed) : base(date, length)
    {
        _speed = speed;
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
}