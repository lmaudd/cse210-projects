using System;
using System.ComponentModel;

public class Swimming : Activity
{
    // Attributes
    private int _lapCount; // for 50 meter pool

    // Constructor
    public Swimming(string date, float length, int lapCount) : base(date, length)
    {
        _lapCount = lapCount;
    }
    
    // Methods
    public override float GetDistance()
    {
        // At the decimal points b/c integer division truncates my decimal to 0 and gives me
        // infinity for the time per lap...
        double distance = _lapCount * 50.0 / 1000.0 * 0.62; // Distance in miles formula
        return (float)distance; // Return distance in miles as a float
    }

    public override string GetActivity()
    {
        return "Swimming";
    }
}