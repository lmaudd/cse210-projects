using System;
// Use https://learn.microsoft.com/en-us/dotnet/api/system.math.round?view=net-10.0#Round1_Example for Math.Round source

class Program
{
    static void Main(string[] args)
    {
        // Step 7: Practice using function class
        Random random = new Random();
        for (int i = 1; i < 101; i++) 
        {
            Fraction frac = new Fraction();

            int top = random.Next(1,21);
            int bottom = random.Next(1,21);
            frac.SetTop(top);
            frac.SetBottom(bottom);

            string text = frac.GetFractionString();
            double dec = frac.GetDecimalValue();
            double decRound = Math.Round(dec, 3);

            Console.WriteLine($"Fraction {i}:  string: {text}  Number: {decRound}");
        }
    }
}