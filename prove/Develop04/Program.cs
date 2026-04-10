using System;

class Program
{
    static void Main(string[] args)
    {
        Breathing a = new Breathing();
        Console.Clear();

        // DateTime start = DateTime.Now;
        // Thread.Sleep(3000);

        // DateTime stop = DateTime.Now;

        // int x = a.CalculateTimeChange(start, stop);
        // Console.WriteLine(x); // Correctly outputed 3

        // a.CountDown(6); // Works

        a.BreathingActivity();

    }   
}