using System;

public class Biking : Activity
{
    // Attributes
    private float _speed; // Speed in miles per hour

    // Constructor
    public Biking(string date, float length, float speed) : base(date, length)
    {
        _speed = speed;
    }
    
    // Methods
    public override float GetSpeed()
    {
        return _speed; // in miles per hour
    }

    public override string GetActivity()
    {
        return "Biking";
    }
}