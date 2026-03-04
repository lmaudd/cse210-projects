using System;

class Program
{
    static void Main(string[] args)
    {
       // DT Practice
       DateTime theCurrentTime = DateTime.Now;
       string dateText = theCurrentTime.ToShortDateString();
       Console.WriteLine(dateText);
    }
}