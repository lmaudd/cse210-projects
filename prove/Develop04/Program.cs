using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Clear();

        DateTime start = DateTime.Now;
        Thread.Sleep(3000);

        DateTime stop = DateTime.Now;

        int difference = (int)stop.Ticks - (int)start.Ticks;
        double seconds = difference * 0.0000001;


        Console.WriteLine($"{stop.Ticks} - {start.Ticks} = {difference} = {seconds}"); /// works!!!!!!!!
    }   
}