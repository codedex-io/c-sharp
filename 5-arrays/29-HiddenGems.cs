// Hidden Gems 🗺️
// Codédex

using System;

class HiddenGems
{
  static void Main()
  {
    string[] recommendations =
    {
      "Visit the museum",
      "Walk through the park",
      "Try the local pizza",
      "See a concert"
    };

    recommendations[1] = "Visit the waterfront";

    Console.WriteLine(recommendations[1]);
  }
}