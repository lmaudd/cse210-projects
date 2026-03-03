using System;

public class Job
{
    // Define member variables (responsibilities) for Job class
    public string _company = "";
    public string _jobTitle = "";
    public string _startYear = "";
    public string _endYear = "";

    // Define methods (behaviors) for the Job class
    public void DisplayInformation()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}