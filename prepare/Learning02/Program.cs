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
        job1.DisplayInformation();

        Job job2 = new Job();
        job2._company = "The Ranch";
        job2._jobTitle = "Farmer";
        job2._startYear = "17";
        job2._endYear = "60";
        job2.DisplayInformation();
    }
}