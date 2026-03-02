using System;

class Program
{
    static void Main(string[] args)
    {
        // Obtain grade from user, convert to integer.
        Console.Write("What is you grade percentage? ");
        string gradeString = Console.ReadLine();
        int grade = int.Parse(gradeString);

        // Determine letter grade via if - else - else if funnel

        if (grade >= 90) // Grade A
        {
            Console.WriteLine("Your grade: A");
            Console.WriteLine("Congratulations! That is a passing grade.");
        }

        else if (grade >= 80) // Grade B
        {
            Console.WriteLine("Your grade: B");
            Console.WriteLine("Congratulations! That is a passing grade.");
        }

        else if (grade >= 70) // Grade C
        {
            Console.WriteLine("Your grade: C");
            Console.WriteLine("Congratulations! That is a passing grade.");
        }

        else if (grade >= 60) // Grade D
        {
            Console.WriteLine("Your grade: D");
            Console.WriteLine("Unfortunately, this is not a passing grade.");
        }

        else // Grade F
        {
            Console.WriteLine("Your grade: F");
            Console.WriteLine("Unfortunately, this is not a passing grade.");
        }
    }
}