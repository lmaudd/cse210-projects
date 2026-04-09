// https://stackoverflow.com/questions/34090397/convert-double-to-float-by-cast-or-convert-tosingle
// https://stackoverflow.com/questions/10851273/why-does-integer-division-in-c-sharp-return-an-integer-and-not-a-float

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
        double distance = _lapCount * 50.0 / 1000.0 * 0.62; // Distance in miles formula
        return (float)distance;
    }

    public override string GetActivity()
    {
        return "Swimming";
    }
}