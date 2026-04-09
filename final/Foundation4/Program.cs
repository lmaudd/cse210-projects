// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types

using System;

class Program
{
    static void Main(string[] args)
    {
        // Create list
        List<Activity> exercises = new List<Activity>{};

        // Instantiate Running
        string rdate = "03 Nov 2022";
        float rlength = 30.0F;
        float rdistance = 3.0F;
        Running running = new Running(rdate, rlength, rdistance);
        exercises.Add(running);

        // Instantiate Biking
        string bdate = "07 Oct 2025";
        float blength = 20.0F;
        float bdistance = 9.0F;
        Biking biking = new Biking(bdate, blength, bdistance);
        exercises.Add(biking);

        // Instantiate Swimming
        string sdate = "23 Sept 2029";
        float slength = 45.0F;
        int slapCount = 7;
        Swimming swimming = new Swimming(sdate, slength, slapCount);
        exercises.Add(swimming);

        // Iterate through list
        foreach (Activity act in exercises)
        {
            string sum = act.GetSummary();
            Console.WriteLine($"\n{sum}\n");
        }
    }
}