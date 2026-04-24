// Invite Only 🎩
// Codédex

using System;

class InviteOnly
{
  static void Main()
  {
    int age = 25;
    bool hasInvite = true;

    if (age > 21 && hasInvite)
    {
      Console.WriteLine("Come on in!");
    }
    else
    {
      Console.WriteLine("Not tonight, buddy");
    }
  }
}