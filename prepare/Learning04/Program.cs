using System;

class Program
{
    static void Main(string[] args)
    {
        // Test 1
        MathAssigment ms = new MathAssigment("Mary Waters", "Calc III", "7.1", "1-45");
        string sum1 = ms.GetSummary();
        string hw1 = ms.GetHomeworkList();

        // Test 2
        WrtitingAssigment ws = new WrtitingAssigment("Mary Water", "Advanced Writing and Reasoning", "Discussion on...");
        string sum2 = ws.GetSummary();
        string hw2 = ws.GetWritingInformation();

        // Print
        Console.WriteLine(sum1);
        Console.WriteLine(hw1);
        Console.WriteLine(sum2);
        Console.WriteLine(hw2);
    }
}