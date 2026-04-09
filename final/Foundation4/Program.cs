// Sources
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/numeric-conversions
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/virtual
// https://learn.microsoft.com/en-us/dotnet/api/system.math.round?view=net-10.0 issue with decimals and floats I can't figure out
// https://stackoverflow.com/questions/10851273/why-does-integer-division-in-c-sharp-return-an-integer-and-not-a-float
// https://stackoverflow.com/questions/34090397/convert-double-to-float-by-cast-or-convert-tosingle 

using System;

class Program
{
    static void Main(string[] args)
    {
        // Create list--------------------------------------------------------
        List<Activity> exercises = new List<Activity>{};

        // Instantiate Running------------------------------------------------
        string rdate = "03 Nov 2022";
        float rlength = 30.0F;  // The F converts double to float, it seems to eliminate the type cast error,
        float rdistance = 3.0F; // though the Microsoft Website was hard to understand, and I don't fully understand it.
        Running running = new Running(rdate, rlength, rdistance);
        exercises.Add(running);

        // Instantiate Biking-------------------------------------------------
        string bdate = "07 Oct 2025";
        float blength = 20.0F;
        float bdistance = 9.0F;
        Biking biking = new Biking(bdate, blength, bdistance);
        exercises.Add(biking);

        // Instantiate Swimming-----------------------------------------------
        string sdate = "23 Sept 2029";
        float slength = 45.0F;
        int slapCount = 7;
        Swimming swimming = new Swimming(sdate, slength, slapCount);
        exercises.Add(swimming);

        // Iterate through list & print summary-------------------------------
        foreach (Activity act in exercises)
        {
            string sum = act.GetSummary();
            Console.WriteLine($"\n{sum}\n");
        }
    }
}