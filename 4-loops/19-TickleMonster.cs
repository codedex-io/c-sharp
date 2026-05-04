// Tickle Monster 🤗
// Codédex

using System;

class TickleMonster
{
  static void Main()
  {
    Console.WriteLine("Tickle tickle 🤗");
    string input = Console.ReadLine();

    while (input != "stop")
    {
      Console.WriteLine("Tickle tickle 🤗");
      input = Console.ReadLine();
    }
  }
}