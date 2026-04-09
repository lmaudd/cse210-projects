// https://stackoverflow.com/questions/34090397/convert-double-to-float-by-cast-or-convert-tosingle

using System;
using System.ComponentModel;

public class Swimming : Activity
{
    // Attributes
    private int _lapCount;

    // Constructor
    public Swimming(string date, float length, int lapCount) : base(date, length)
    {
        _lapCount = lapCount;
    }
    
    // Methods
    public override float GetDistance()
    {
        double distance = _lapCount * 50 / 1000 * 0.62; // Distance in miles formula
        return (float)distance;
    }

    public override float GetSpeed()
    {
        float length = GetLength();
        float distance = GetDistance();
        float speed = (distance / length) * 60;
        return speed;
    }
}