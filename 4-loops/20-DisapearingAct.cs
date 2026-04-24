// Disappearing Act 🪄
// Codédex

using System;

class DisappearingAct
{
  static void Main()
  {
    int invisibilityLevel = 1;
    string input = "";

    while (input != "compose yourself!")
    {
      Console.WriteLine("You fade further out of existence… level " + invisibilityLevel);
      invisibilityLevel++;
      input = Console.ReadLine();
    }
  }
}