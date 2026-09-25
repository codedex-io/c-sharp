// Built to Order 🖥️
// Codédex

using System;

class BuiltToOrder
{
  public string graphicsCard;
  public int ram;

  public Computer(string graphicsCard, int ram)
  {
    this.graphicsCard = graphicsCard;
    this.ram = ram;
  }

  static void Main()
  {
    Computer gamingPC = new Computer("RTX 5070", 32);

    Console.WriteLine(gamingPC.graphicsCard + " with " + gamingPC.ram + "GB RAM");
  }
}