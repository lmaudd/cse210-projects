using System;

public class Resume
{
    // Define member variables (responsibilities) for Resume class
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    // Add a Display method to the Resume class
    public void Display()
    {
        Console.WriteLine(" ");
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        
        foreach (Job job in _jobs)
        {
            job.DisplayInformation();
        }
        Console.WriteLine(" ");

    }
}