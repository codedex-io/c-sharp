// Year of the X 📆
// Codédex

using System;

class YearOfTheX
{
  static void Main()
  {
    Console.WriteLine("What year were you born?");
    
    string input = Console.ReadLine();
    int birthYear = int.Parse(input);

    int cycle = 12;

    int yearsUntilZodiac = (cycle - (birthYear % cycle)) % cycle;

    Console.WriteLine("Your zodiac year comes again in " + yearsUntilZodiac + " year(s)!");
  }
}