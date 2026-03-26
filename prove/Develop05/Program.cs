using System;

class Program
{
    static void Main(string[] args)
    {
        string goal = "Drink more water.";
        int points = 50;
        SimpleGoal sg = new SimpleGoal(goal, points);

        int tp1 = sg.GetTotalPoints();
        sg.RecordEvent();
        int tp2 = sg.GetTotalPoints();

        Console.WriteLine(tp1);
        Console.WriteLine(tp2);
    }
}