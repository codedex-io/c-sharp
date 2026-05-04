using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your birth year: ");
        int birthYear = int.Parse(Console.ReadLine());

        int yearsPassed = DateTime.Now.Year - birthYear;
        int yearsUntilNextZodiac = (12 - yearsPassed % 12) % 12;
        Console.WriteLine(yearsUntilNextZodiac);
    }
}
