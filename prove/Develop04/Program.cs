using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" ");
        List<char> temp = new List<char> {'|', '/', '-', '\\',
                                          '|', '/', '-', '\\', 
                                          '|', '/', '-', '\\',
                                          '|', '/', '-', '\\',
                                          '|'};

        foreach (char i in temp)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine(" ");

        // |/-\|/-\|
    }   
}