// The Cookout 🍔
// Codédex

using System;

class TheCookout
{
  static void Main()
  {
    Allergies("Tomato");
    Allergies("Dairy");
    Allergies("Gluten");
  }

  static void Allergies(string food)
  {
    Console.WriteLine("We'll make sure to provide snacks that don't contain" + food + "!");
  }
}