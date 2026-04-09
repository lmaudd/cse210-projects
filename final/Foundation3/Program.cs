using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate Lecture~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        string lectureTitle = "Discourse on Pasta";
        string lectureDescription = "Jordan Ravilioli comes all the way from Texas to teach us about pasta!";
        string lectureDate = "04 Oct 2023";
        string lectureTime = "4:30 p.m.";
        string lectureSpeaker = "Jordan Ravilioli";
        int lectureCapacacity = 200;

        Address lectureAddress = new Address("123 West Hollywood, CA, USA"); // Instantiate Address

        Lecture lecture = new Lecture(lectureTitle, lectureDescription, lectureDate, lectureTime, lectureAddress, 
            lectureSpeaker, lectureCapacacity); // Instantiate Lecture

        // Instantiate Reception~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        string receptionTitle = "Wedding Reception";
        string receptionDescription = "Join us for the union of Jon Smith and Tina Smithy";
        string receptionDate = "03 Oct 2027";
        string receptionTime = "11:30 a.m.";
        string receptionRsvpEmail = "reception@gmail.com";

        Address receptionAddress = new Address("123 Reception Hall, ID, USA"); // Instantiate Address

        Reception reception = new Reception(receptionTitle, receptionDescription, receptionDate, receptionTime, 
            receptionAddress, receptionRsvpEmail); // Instantiate Reception
    
        // Instantiate Ooutdoor Gathering~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        string outdoorGatheringTitle = "Picnic Time";
        string outdoorGatheringDescription = "Join us for night-time sandwich picnic! Sandwiches provided.";
        string outdoorGatheringDate = "01 Nov 2045";
        string outdoorGatheringTime = "11:45 p.m.";
        string outdoorGatheringWeather = "Sunny";

        Address outdoorGatheringAddress = new Address("123 Picnic Place, UT, USA"); // Instantiate Address

        OutdoorGathering outdoorGathering = new OutdoorGathering(outdoorGatheringTitle, outdoorGatheringDescription, 
            outdoorGatheringDate, outdoorGatheringTime, outdoorGatheringAddress, outdoorGatheringWeather); // Instantiate Outdoor Gathering
    
        
        // Test Classes with output ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        string lectureStandardDetails = lecture.GetStandardDetails();
        string lectureFullDetails = lecture.GetFullDetails();   
        string lectureShortDescription = lecture.GetShortDescription();

        Console.WriteLine("\nLecture Information ---------------------------------------------------------------------------------\n");
        Console.WriteLine(lectureStandardDetails);
        Console.WriteLine(lectureFullDetails);
        Console.WriteLine($"\n{lectureShortDescription}");

        string receptionStandardDetails = reception.GetStandardDetails();
        string receptionFullDetails = reception.GetFullDetails();
        string receptionShortDescription = reception.GetShortDescription(); 

        Console.WriteLine("\nReception Information -------------------------------------------------------------------------------\n");
        Console.WriteLine(receptionStandardDetails);
        Console.WriteLine(receptionFullDetails);
        Console.WriteLine($"\n{receptionShortDescription}");

        string outdoorGatheringStandardDetails = outdoorGathering.GetStandardDetails();
        string outdoorGatheringFullDetails = outdoorGathering.GetFullDetails();
        string outdoorGatheringShortDescription = outdoorGathering.GetShortDescription(); 

        Console.WriteLine("\nOutdoorGathering Information -------------------------------------------------------------------------\n");
        Console.WriteLine(outdoorGatheringStandardDetails);
        Console.WriteLine(outdoorGatheringFullDetails);
        Console.WriteLine($"\n{outdoorGatheringShortDescription}");
    }
}