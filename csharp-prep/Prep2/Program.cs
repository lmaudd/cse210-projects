using System;

class Program
{
    static void Main(string[] args)
    {
        // Obtain grade from user, convert to integer
        Console.Write("What is you grade percentage? ");
        string gradeString = Console.ReadLine();
        float grade = float.Parse(gradeString);

        // Initialize gradeLetter and passFailString
        string gradeLetter;
        string passFailString;

        // Determine letter grade via if - else - else if funnel

        if (grade >= 90) // Grade A
        {
            gradeLetter = "A";
            passFailString = "Congratulations! That is a passing grade.";
        }

        else if (grade >= 80) // Grade B
        {
            gradeLetter = "B";
            passFailString = "Congratulations! That is a passing grade.";
        }

        else if (grade >= 70) // Grade C
        {
            gradeLetter = "C";
            passFailString = "Congratulations! That is a passing grade.";
        }

        else if (grade >= 60) // Grade D
        {
            gradeLetter = "D";
            passFailString = "Unfortunately, this is not a passing grade.";
        }

        else // Grade F
        {
            gradeLetter = "F";
            passFailString = "Unfortunately, this is not a passing grade.";
        }

        // Print user letter grade and acknowledgement of pass or fail
        Console.WriteLine($"Your grade: {gradeLetter}");
        Console.WriteLine(passFailString);
    }
}