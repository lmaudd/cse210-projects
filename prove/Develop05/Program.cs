using System;

class Program
{
    static void Main(string[] args)
    {
        // Test SimpleGoal
        // string goal = "Drink more water.";
        // int points = 50;
        // SimpleGoal sg = new SimpleGoal(goal, points);

        // int tp1 = sg.GetTotalPoints();
        // sg.RecordEvent();
        // int tp2 = sg.GetTotalPoints();

        // Console.WriteLine(tp1);
        // Console.WriteLine(tp2);

        // Test EternalGoal
        string goal = "Drink more water.";
        int points = 50;
        EternalGoal eg = new EternalGoal(goal, points);

        int tp1 = eg.GetTotalPoints();
        eg.RecordEvent();
        int tp2 = eg.GetTotalPoints();
        eg.RecordEvent();
        eg.RecordEvent();
        eg.RecordEvent();
        int tp3 = eg.GetTotalPoints();

        Console.WriteLine(tp1);
        Console.WriteLine(tp2);
        Console.WriteLine(tp3);
    }
}