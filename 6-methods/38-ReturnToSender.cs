// Return To Sender ✈️
// Codédex

using System;

class ReturnToSender
{
  static void Main()
  {
    int remainingPoints = PointsLeft(50000, 35000);
    Console.WriteLine(remainingPoints);
  }

  static int PointsLeft(int startingPoints, int pointsNeeded)
  {
    return startingPoints - pointsNeeded;
  }
}
