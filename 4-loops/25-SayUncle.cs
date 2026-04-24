// Say Uncle 💬
// Codédex

using System;

class SayUncle
{
  static void Main()
  {
    string input = "";

    while (input != "uncle")
    {
      input = Console.ReadLine();

      if (input != "uncle")
      {
        Console.WriteLine(input);
      }
    }
  }
}