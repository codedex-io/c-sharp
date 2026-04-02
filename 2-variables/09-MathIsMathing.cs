// Math is Mathing 📓
// Codédex

using System;

class MathIsMathing
{
  static void Main()
  {
    int totalPeople = 23;
    int ticketsPerBundle = 5;
    
    int fullBundles = totalPeople / ticketsPerBundle;
    int peopleWithoutTickets = totalPeople % ticketsPerBundle;
    
    Console.WriteLine("Full bundles you can buy: " + fullBundles);
    Console.WriteLine("People without tickets: " + peopleWithoutTickets);
  }
}