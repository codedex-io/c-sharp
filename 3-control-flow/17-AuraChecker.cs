// Aura Checker 🌈
// Codédex

using System;

class AuraChecker
{
  static void Main()
  {
    Console.WriteLine("Enter a number from 1-10:");

    string input = Console.ReadLine();
    int number = int.Parse(input);

    if (number >= 8)
    {
      Console.WriteLine("Immaculate vibes ✨");
    }
    else
    {
      Console.WriteLine("I'm detecting some dark energy, but we can turn this around. 🌫️");
    }
  }
}