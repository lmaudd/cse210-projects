using System;

class Program
{
    static void Main(string[] args)
    {
       // List Practice
       List<string> myList = new List<String> { "C#", "Java", "Javascript" };
       
        foreach (string listElement in myList) 
        {
            Console.WriteLine(listElement);
        }
    }
}