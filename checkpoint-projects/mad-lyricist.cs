// Mad Lyricist 🎤
// Codédex

using System;

class MadLyricist
{
  static void Main()
  {
    bool makeAnotherSong = true;

    while (makeAnotherSong)
    {
      Console.WriteLine("🎤 Welcome to Mad Lyricist!");
      Console.WriteLine();

      Console.WriteLine("Enter a noun:");
      Console.Write(">> ");
      string noun = Console.ReadLine();

      Console.WriteLine();

      Console.WriteLine("Enter a verb:");
      Console.Write(">> ");
      string verb = Console.ReadLine();

      Console.WriteLine();

      Console.WriteLine("Enter an adjective:");
      Console.Write(">> ");
      string adjective = Console.ReadLine();

      Console.WriteLine();

      Console.WriteLine("Enter an object:");
      Console.Write(">> ");
      string obj = Console.ReadLine();

      Console.WriteLine();

      Console.WriteLine("Enter a place:");
      Console.Write(">> ");
      string place = Console.ReadLine();

      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine("🎶 Your Song 🎶");
      Console.WriteLine();

      // Song output (Twinkle template)
      Console.WriteLine("Twinkle, twinkle, little " + noun + ",");
      Console.WriteLine("How I " + verb + " what you are.");
      Console.WriteLine();
      Console.WriteLine("Up above the bug so " + adjective + ",");
      Console.WriteLine("Like a " + obj + " in the " + place + ".");
      Console.WriteLine();

      // Logical operator requirement example
      if (noun != "" && verb != "" && adjective != "" && obj != "" && place != "")
      {
        Console.WriteLine("✨ Your lyrics are complete and ready for the charts!");
      }
      else
      {
        Console.WriteLine("⚠️ Some lyrics feel unfinished...");
      }

      Console.WriteLine();
      Console.WriteLine("Would you like to create another song? (y/n)");
      Console.Write(">> ");
      string again = Console.ReadLine();

      if (again != "y")
      {
        makeAnotherSong = false;
      }

      Console.WriteLine();
      Console.WriteLine("Thanks for using Mad Lyricist! 🎤✨");
    }
  }
}