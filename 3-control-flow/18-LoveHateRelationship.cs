// Love Hate Relationship 🛼
// Codédex

using System;

class LoveHateRelationship
{
  static void Main()
  {
    Console.WriteLine("Sweet or savory?");
    string answer = Console.ReadLine();

    if (answer == "sweet")
    {
      Console.WriteLine("THINGS YOU LOVE:");
      Console.WriteLine("texting 'hehe' instead of reacting normally");
      Console.WriteLine("soft lighting that makes everything feel like a memory");
      Console.WriteLine("making plans you already know you might cancel");
      Console.WriteLine("romanticizing things that are not actually romantic");
    }
    else if (answer == "savory")
    {
      Console.WriteLine("THINGS YOU LOVE:");
      Console.WriteLine("food that is aggressively seasoned for no reason other than truth");
      Console.WriteLine("silence while eating because it deserves respect");
      Console.WriteLine("small rituals around coffee that feel non-negotiable");
      Console.WriteLine("knowing immediately when something is under-seasoned emotionally or otherwise");
    }
    else
    {
      Console.WriteLine("THINGS YOU HATE:");
      Console.WriteLine("being asked to choose when both options feel incomplete");
      Console.WriteLine("small talk before your brain has fully loaded");
      Console.WriteLine("when things are almost right but not quite enough to ignore");
      Console.WriteLine("performative enthusiasm before understanding the situation");
    }
  }
}