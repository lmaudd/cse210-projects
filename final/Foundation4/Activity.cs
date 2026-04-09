using System;
using System.Runtime.Intrinsics.X86;

public class Activity
{
    // Attributes
    private string _date; // String to store date
    private float _length; // Length of exercise in minutes

    // Constructor
    public Activity(string date, float length)
    {
        _date = date;
        _length = length;
    }

    // Getters for parent variables
    public float GetLength()
    {
        return _length;
    }
    
    // Methods / Virtual Calculations
    public virtual float GetDistance()
    {
        // Equations: v = d / t ==> d = v * t

        // Get variables and perform conversions
        float speed = GetSpeed(); // Speed in miles per hour
        float timeMinutes = GetLength(); // Time in minutes
        float timeHours = timeMinutes / 60; // Time in hours

        // Calculations & return
        float distance = speed * timeHours; // Distance in miles
        return distance;
    }

    public virtual float GetSpeed()
    {
        // Equations: v = d / t

        // Get variables and perform conversions
        float distance = GetDistance(); // Distance in miles
        float timeMinutes = GetLength(); // Time in minutes
        float timeHours = timeMinutes / 60; // Time in hours

        // Calculations & return
        float speed = distance / timeHours; // Speed in miles per hour
        return speed;
    }

    public virtual float GetPace()
    {
        // Equations: pace = 60 / speed
        float speed = GetSpeed(); // Speed in miles per hour
        float pace = 60 / speed; // Pace in minutes per mile
        return pace;
    }

    // Methods for Summary
    public virtual string GetActivity()
    {
        // Placeholder for override
        return "";
    }

    public string GetSummary()
    {
        // Get values
        string activity = GetActivity();
        float distance = GetDistance();
        float speed = GetSpeed();
        float pace = GetPace();

        // Return
        return $"{_date} {activity} ({_length} min): Distance {distance} miles, Speed {speed} mph, Pace {pace} min per mile";
    }
}