// Year of the Horse 🐎
// Codédex

using System;

class Program
{
  static void Main()
  {
    Console.WriteLine("What year were you born?");
    
    string input = Console.ReadLine();
    int birthYear = int.Parse(input);
    
    int horseYear = 2014;
    int cycle = 12;

    int yearsUntilHorse = (cycle - ((birthYear - horseYear) % cycle)) % cycle;

    Console.WriteLine("Your birthday is " + yearsUntilHorse "years away from the next year of the horse!");
  }
}