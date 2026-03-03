using System;

class Program
{
    static void Main(string[] args)
    {
        // Test your Job class with 2 jobs
        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Consultant";
        job1._startYear = "2003";
        job1._endYear = "2017";

        Job job2 = new Job();
        job2._company = "The Farm";
        job2._jobTitle = "Farmer";
        job2._startYear = "1780";
        job2._endYear = "1799";

        Job job3 = new Job();
        job3._company = "NASA";
        job3._jobTitle = "Astronaut";
        job3._startYear = "2034";
        job3._endYear = "2049";

        // Test your Resume class with 2 resumes
        Resume resume = new Resume();
        resume._name = "Harry Styles";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume._jobs.Add(job3);
        resume.Display();
    }
}