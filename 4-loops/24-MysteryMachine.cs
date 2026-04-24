// Mystery Machine ⏳
// Codédex

using System;

class MysteryMachine
{
  static void Main()
  {
    int timeDistortion = 0;

    for (int i = 0; i < 5; i++)
    {
      timeDistortion += 3;
      Console.WriteLine("Time distortion: " + timeDistortion);
    }
  }
}