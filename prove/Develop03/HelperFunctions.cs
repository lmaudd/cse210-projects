// https://stackoverflow.com/questions/8879774/how-can-i-check-if-a-string-contains-a-character-in-c
// https://stackoverflow.com/questions/748062/return-multiple-values-to-a-method-caller

using System;

class HelperFunctions
{
    // Class Methods ///////////////////////////////////////////////////
    public (string, string) Load()
    {
        Console.WriteLine("Loading...");
        string text = "";
        string reference = "";

        // Load
        string[] lines = System.IO.File.ReadAllLines("StoredScriptures.txt");
        
        foreach (string line in lines) // Iterate through the whole file
        {
            string[] parts = line.Split("~");
            text = parts[0];
            reference = parts[1];
        }

        Console.WriteLine("Loading succesful.");
        Thread.Sleep(2000); // Sleep for number/1000 sec

        return (text, reference);
    }

    public void Quit()
    {
        Thread.Sleep(500); // Sleep for number/1000 sec
        Console.WriteLine("Thank you for using!");
        Console.WriteLine(" ");
    }

    public void Menu()
    {
        Console.Clear();
        Console.WriteLine(" ");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("| User Options Menu ~ Type Word or Entr Key |");
        Console.WriteLine("|   (1) 'Load' scripture                    |");
        Console.WriteLine("|   (2) 'Quit' application                  |");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine(" ");
    }

    public string UserInquire()
    {
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.Write("Type here: ");
        return Console.ReadLine();
    }
}


// public void Load()
//     {   
//         string fileName = Console.ReadLine(); 

//         string[] lines = System.IO.File.ReadAllLines(fileName);

//             foreach (string line in lines) // Iterate through the whole file
//             {
//                     string[] parts = line.Split("~");
//                     string date = parts[0];
//                     string prompt = parts[1];
//                     string answer = parts[2];
//                     Entry entry = new Entry();
//                     entry.StoreInformation(date, prompt, answer);
//                     _entries.Add(entry);
//             }