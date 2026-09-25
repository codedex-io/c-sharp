// Community Gardener 🫜
// Codédex

using System;

class CommunityGardener
{
  public string name;
  public int height;
  public bool edible;

  static void Main()
  {
    Plant plant1 = new Plant();
    Plant plant2 = new Plant();
    Plant plant3 = new Plant();
    Plant plant4 = new Plant();


    plant1.name = "Garlic";
    plant1.height = 30;
    plant1.edible = true;

    plant2.name = "Tomato";
    plant2.height = 110;
    plant2.edible = true; 

    plant3.name = "Okra";
    plant3.height = 90;
    plant3.edible = true;

    plant4.name = "Marigolds";
    plant4.height = 45;
    plant4.edible = true;

    Console.WriteLine(plant1.name + " is " + plant1.height + " inches tall." " It is" + plant1.edible + " that it is edible.");
    Console.WriteLine(plant2.name + " is " + plant2.height + " inches tall." " It is" + plant2.edible + " that it is edible.");
    Console.WriteLine(plant3.name + " is " + plant3.height + " inches tall." " It is" + plant3.edible + " that it is edible.");
    Console.WriteLine(plant4.name + " is " + plant4.height + " inches tall." " It is" + plant4.edible + " that it is edible.");

  }
}