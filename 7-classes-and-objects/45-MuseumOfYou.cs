// Museum of You 🖼️
// Codédex

using System;

class MuseumOfYou
{
  public string title;
  public int year;
  public string memory;


  public Artwork(string title, int year, string memory)
  {
    this.title = title;
    this.year = year;
    this.memory = memory;
  }

  static void Main()
  {
    Artwork artwork1 = new Artwork("Starry Night", "Vincent van Gogh", 1889);
    Artwork artwork2 = new Artwork("Water Lilies", "Claude Monet", 1906);
    Artwork artwork3 = new Artwork("Campbell's Soup Cans", "Andy Warhol", 1962);

    Console.WriteLine(artwork1.title + " by " + artwork1.artist + " (" + artwork1.year + ")");
    Console.WriteLine(artwork2.title + " by " + artwork2.artist + " (" + artwork2.year + ")");
    Console.WriteLine(artwork3.title + " by " + artwork3.artist + " (" + artwork3.year + ")");
  }
}