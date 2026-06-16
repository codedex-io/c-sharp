// Doomsday Prepper 🥫
// Codédex

using System;

class DoomsdayPrepper
{
  static void Main()
  {
    string[] supplies =
    {
      "Water bottles",
      "Canned food",
      "Batteries",
      "First aid kits",
      "Flashlights"
    };

    int[] quantities =
    {
      24,
      18,
      30,
      8,
      10
    };

    quantities[2] = 32;

    int total = 0;

    for (int i = 0; i < supplies.Length; i++)
    {
      Console.WriteLine(supplies[i] + " - " + quantities[i]);
      total += quantities[i];
    }

    Console.WriteLine("Total supplies: " + total);
  }
}