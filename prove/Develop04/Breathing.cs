// using System;

// class Breathing : Activity
// {
//     // Constructor
//     public Breathing() : base()
//     {
//         string name = "Breathing Activity";

//         string description = "This activity will help you relax by walking you through breathing " +
//                              "in and out slowly. Clear you mind and focus on your breathing.";
        
//         SetName(name);
//         SetDescription(description);
//     }

//     // Methods
//     public void BreathingActivity()
//     {
//         Console.Clear(); // Empty console
//         StartingMessage(); // Display header message

//         int seconds = InquireTime() ; // Ask how long to do activity and store

//         Console.Clear(); // Empty console
//         Console.WriteLine("Get ready...");
//         Spinner(4); // Display spinner for 4 seconds
//         Console.WriteLine(); // Empty console space

//         // Define time variables for time keeping
//         DateTime startTime = DateTime.Now;
//         DateTime currentTime = DateTime.Now;

//         while (currentTime - startTime < seconds)
//         {
        
//         }
//     }
// }