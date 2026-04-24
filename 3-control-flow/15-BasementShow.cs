// Basement Show 🔊
// Codédex

using System;

class BasementShow
{
  static void Main()
  {
    int noiseLevel = 65;

    if (noiseLevel < 40)
    {
      Console.WriteLine("No complaints yet 🔊");
    }
    else if (noiseLevel <= 70)
    {
      Console.WriteLine("The neighbors are getting annoyed 😬");
    }
    else
    {
      Console.WriteLine("We're gonna get shut down! 🚨");
    }
  }
}