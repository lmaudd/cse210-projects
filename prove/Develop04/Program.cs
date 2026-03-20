using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("|");
        // Thread.Sleep(1000);

        // Console.Write("\b \b");
        // Console.Write("/");
        // Thread.Sleep(1000);

        // Console.Write("\b \b");
        // Console.Write("--");
        // Thread.Sleep(1000);

        // Console.Write("\b \b");
        // Console.Write("/");
        // Thread.Sleep(1000);

        // Console.Write("\b \b");
        // Console.Write("|");
        // Thread.Sleep(1000);

        // Console.Write("\b \b");
        // Console.Write("/");
        // Thread.Sleep(1000);

        // Activity activity = new Activity("Test");
        // activity.StartingMessage();
        // activity.EndingMessage();
        // activity.InquireTime();

        ReflectionActivity refAct = new ReflectionActivity("Reflecting Activity");
        refAct.InitiateActivity();

    }   
}