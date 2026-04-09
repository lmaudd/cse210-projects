using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate Lecture
        string title = "Discourse on Pasta";
        string description = "Jordan Ravilioli comes all the way from Texas to teach us about pasta!";
        string date = "04 Oct 2023";
        string time = "4:30 p.m.";
        string speaker = "Jordan Ravilioli";
        int capacacity = 200;

        Address address = new Address("123 West Hollywood, CA, USA");

        Lecture lecture = new Lecture(title, description, date, time, address, speaker, capacacity);
    }
}