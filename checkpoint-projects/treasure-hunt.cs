// Treasure Hunt 🪑
// Codédex

using System;

class TreasureHunt
{
  static void Main()
  {
    Console.WriteLine("Welcome to Treasure Hunt! 🪑🏺");
    Console.WriteLine();

    Console.Write("What's your name? ");
    string name = Console.ReadLine();

    int money = 20;
    int energy = 3;
    int score = 0;

    bool playing = true;
    int turn = 1;

    while (playing)
    {
      Console.WriteLine();
      Console.WriteLine("Turn: " + turn);
      Console.WriteLine("Money: $" + money);
      Console.WriteLine("Energy: " + energy);
      Console.WriteLine("Score: " + score);

      Console.WriteLine();
      Console.WriteLine("Where would you like to search?");
      Console.WriteLine("[a] Thrift Store");
      Console.WriteLine("[b] Stoop Sale");
      Console.Write(">> ");

      string choice = Console.ReadLine();

      Console.WriteLine();

      if (choice == "a")
      {
        if (turn % 2 == 0)
        {
          Console.WriteLine("You found a vintage lamp for $5!");
          money = money - 5;
          score = score + 5;
        }
        else if (money > 10 && energy > 1)
        {
          Console.WriteLine("You found a cool jacket for $8.");
          money = money - 8;
          score = score + 4;
        }
        else
        {
          Console.WriteLine("Nothing good here today.");
          energy = energy - 1;
        }
      }
      else if (choice == "b")
      {
        if (score >= 5 && money > 5)
        {
          Console.WriteLine("You found a rare collectible!");
          money = money - 3;
          score = score + 6;
        }
        else if (turn % 3 == 0)
        {
          Console.WriteLine("You accidentally bought a broken chair.");
          money = money - 4;
          score = score - 2;
        }
        else
        {
          Console.WriteLine("A friendly seller gives you a free sticker.");
          energy = energy + 1;
        }
      }
      else
      {
        Console.WriteLine("You wandered around and wasted time...");
        energy = energy - 1;
      }

      // LOGICAL OPERATORS USED HERE
      if (money <= 0 || energy <= 0)
      {
        playing = false;
      }
      else
      {
        Console.WriteLine();
        Console.WriteLine("Keep searching? [y/n]");
        Console.Write(">> ");

        string again = Console.ReadLine();

        if (again != "y")
        {
          playing = false;
        }
      }

      turn = turn + 1;
    }

    Console.WriteLine();
    Console.WriteLine("Game Over!");
    Console.WriteLine("Final Score: " + score);

    if (score >= 12)
    {
      Console.WriteLine("Treasure Hunter Rank: \"Lucky Finder\"");
    }
    else if (score >= 6)
    {
      Console.WriteLine("Treasure Hunter Rank: \"Weekend Browser\"");
    }
    else
    {
      Console.WriteLine("Treasure Hunter Rank: \"Empty-Handed Wanderer\"");
    }
  }
}