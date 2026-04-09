using System;

abstract class Activity
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
    
    // Methods
    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace();
}