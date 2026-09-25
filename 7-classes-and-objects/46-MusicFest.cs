// Music Fest 🤘
// Codédex

using System;

class MusicFestival
{
  public string name;
  public string genre;
  public string setTime;
  public int day;

  public Artist(string name, string genre, string setTime, int day)
  {
    this.name = name;
    this.genre = genre;
    this.setTime = setTime;
    this.day = day;
  }

  static void Main()
  {
    Artist artist1 = new Artist("Doechii", "Hip-Hop", "5:00 PM", 1);
    Artist artist2 = new Artist("MUNA", "Indie Pop", "6:30 PM", 1);
    Artist artist3 = new Artist("Tyler the Creator", "Hip-Hop", "8:00 PM", 1);
    Artist artist4 = new Artist("Billie Eilish", "Pop", "9:30 PM", 1);
    Artist artist5 = new Artist("Charli XCX", "Pop", "11:00 PM", 1);

    Artist artist6 = new Artist("Beethoven", "Classical", "5:00 PM", 2);
    Artist artist7 = new Artist("Nina Simone", "Jazz", "6:30 PM", 2);
    Artist artist8 = new Artist("Talking Heads", "New Wave", "8:00 PM", 2);
    Artist artist9 = new Artist("David Bowie", "Rock", "9:30 PM", 2);
    Artist artist10 = new Artist("Dolly Parton", "Country", "11:00 PM", 2);

    Console.WriteLine("========================================");
    Console.WriteLine("             SWAMP FEST");
    Console.WriteLine("========================================");
    Console.WriteLine();
    Console.WriteLine("                 DAY 1");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine(artist1.setTime + "   " + artist1.name);
    Console.WriteLine(artist2.setTime + "   " + artist2.name);
    Console.WriteLine(artist3.setTime + "   " + artist3.name);
    Console.WriteLine(artist4.setTime + "   " + artist4.name);
    Console.WriteLine(artist5.setTime + "   " + artist5.name);
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("                 DAY 2");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine(artist6.setTime + "   " + artist6.name);
    Console.WriteLine(artist7.setTime + "   " + artist7.name);
    Console.WriteLine(artist8.setTime + "   " + artist8.name);
    Console.WriteLine(artist9.setTime + "   " + artist9.name);
    Console.WriteLine(artist10.setTime + "   " + artist10.name);
    Console.WriteLine();
    Console.WriteLine("========================================");
  }
}