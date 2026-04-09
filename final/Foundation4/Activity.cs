// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/virtual

using System;

public class Activity
{
    // Attributes
    private string _date;
    private float _length;

    // Constructor
    public Activity(string date, float length)
    {
        _date = date;
        _length = length;
    }

    // Getters
    public float GetLength()
    {
        return _length;
    }
    
    // Methods
    public virtual float GetDistance()
    {
        float length = GetLength();
        float speed = GetSpeed();
        float distance = (speed / 60) * length;
        return distance;
    }

    public virtual float GetSpeed()
    {
        float length = GetLength();
        float distance = GetDistance();
        float speed = (distance / length) * 60;
        return speed;
    }

    public virtual float GetPace()
    {
        float speed = GetSpeed();
        float pace = 60 / speed;
        return pace;
    }
}