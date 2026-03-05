using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        // Loop test
        string loopCondition = "0";
        Journal journal = new Journal();

        while (loopCondition == "0")
        {
            journal.GetEntry();

            Console.Write("Would you like to continue? (0=yes): ");
            loopCondition = Console.ReadLine();
        }

        journal.DisplayAll();
    }
}