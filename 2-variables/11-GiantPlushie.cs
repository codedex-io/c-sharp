// Giant Plushie 🧸
// Codédex

using System;

class GiantPlushie
{
  static void Main()
  {
    Console.WriteLine("How many tickets do you have?");

    string input = Console.ReadLine();
    int tickets = int.Parse(input);

    int costPerPlushie = 50;

    int plushies = tickets / costPerPlushie;
    int leftoverTickets = tickets % costPerPlushie;

    Console.WriteLine("You can get " + plushies + " giant Hello Kitty plushie(s)!");
    Console.WriteLine("Tickets left over: " + leftoverTickets);
  }
}