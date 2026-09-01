// Ticket Pool 🎟️
// Codédex

using System;

class TicketPool
{
  static void Main()
  {
    CalculateCost("Chappell Roan", 100, 5, 4);
    CalculateCost("Charli XCX", 300, 8, 7);
    CalculateCost("Phoebe Bridgers", 150, 6, 5);
  }

  static void CalculateCost(string artist, int ticketPrice, int numberOfTickets, int numberOfPeople)
  {
    int total = ticketPrice * numberOfTickets;
    int costPerPerson = total / numberOfPeople;

    Console.WriteLine(artist + ": $" + costPerPerson + " per person");
  }
}