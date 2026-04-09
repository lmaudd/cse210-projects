// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types

using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate Running
        string rdate = "03 Nov 2022";
        float rlength = 30.0F;
        float rdistance = 3.0F;
        Running running = new Running(rdate, rlength, rdistance);
        string rsummary = running.GetSummary();
        // Console.WriteLine(rsummary);

        // Instantiate Biking
        string bdate = "03 Nov 2022";
        float blength = 30.0F;
        float bdistance = 6.0F;
        Biking biking = new Biking(bdate, blength, bdistance);
        string bsummary = biking.GetSummary();
        // Console.WriteLine(bsummary);


        // Instantiate Swimming


    }
}