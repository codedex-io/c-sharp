// Tic-Tac-Toe
// Codédex

using System;

class TicTacToe
{
  static void Main()
  {
    // BOARD SETUP
    string spot1 = "1";
    string spot2 = "2";
    string spot3 = "3";
    string spot4 = "4";
    string spot5 = "5";
    string spot6 = "6";
    string spot7 = "7";
    string spot8 = "8";
    string spot9 = "9";

    // PLAYER SETUP
    Console.Write("Player 1 name: ");
    string player1 = Console.ReadLine();

    Console.Write("Player 2 name: ");
    string player2 = Console.ReadLine();

    string currentPlayer = "X";
    string currentName = player1;

    // GAME STATE
    bool playing = true;
    int turns = 0;

    // GAME LOOP
    while (playing)
    {
      Console.Clear();

      // Display board
      Console.WriteLine(spot1 + " | " + spot2 + " | " + spot3);
      Console.WriteLine("--+---+--");
      Console.WriteLine(spot4 + " | " + spot5 + " | " + spot6);
      Console.WriteLine("--+---+--");
      Console.WriteLine(spot7 + " | " + spot8 + " | " + spot9);

      Console.WriteLine();
      Console.Write(currentName + "'s turn (" + currentPlayer + "): ");

      string choice = Console.ReadLine();

      bool validMove = true;

      // MOVE LOGIC
      if (choice == "1" && spot1 == "1")
      {
        spot1 = currentPlayer;
      }
      else if (choice == "2" && spot2 == "2")
      {
        spot2 = currentPlayer;
      }
      else if (choice == "3" && spot3 == "3")
      {
        spot3 = currentPlayer;
      }
      else if (choice == "4" && spot4 == "4")
      {
        spot4 = currentPlayer;
      }
      else if (choice == "5" && spot5 == "5")
      {
        spot5 = currentPlayer;
      }
      else if (choice == "6" && spot6 == "6")
      {
        spot6 = currentPlayer;
      }
      else if (choice == "7" && spot7 == "7")
      {
        spot7 = currentPlayer;
      }
      else if (choice == "8" && spot8 == "8")
      {
        spot8 = currentPlayer;
      }
      else if (choice == "9" && spot9 == "9")
      {
        spot9 = currentPlayer;
      }
      else
      {
        validMove = false;
        Console.WriteLine("Invalid move!");
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
      }

      // ONLY CONTINUE IF MOVE WAS VALID
      if (validMove)
      {
        turns++;

        // WIN CONDITIONS
        bool winner =
          (spot1 == currentPlayer && spot2 == currentPlayer && spot3 == currentPlayer) ||
          (spot4 == currentPlayer && spot5 == currentPlayer && spot6 == currentPlayer) ||
          (spot7 == currentPlayer && spot8 == currentPlayer && spot9 == currentPlayer) ||
          (spot1 == currentPlayer && spot4 == currentPlayer && spot7 == currentPlayer) ||
          (spot2 == currentPlayer && spot5 == currentPlayer && spot8 == currentPlayer) ||
          (spot3 == currentPlayer && spot6 == currentPlayer && spot9 == currentPlayer) ||
          (spot1 == currentPlayer && spot5 == currentPlayer && spot9 == currentPlayer) ||
          (spot3 == currentPlayer && spot5 == currentPlayer && spot7 == currentPlayer);

        // END GAME CHECK
        if (winner)
        {
          Console.Clear();

          Console.WriteLine(spot1 + " | " + spot2 + " | " + spot3);
          Console.WriteLine("--+---+--");
          Console.WriteLine(spot4 + " | " + spot5 + " | " + spot6);
          Console.WriteLine("--+---+--");
          Console.WriteLine(spot7 + " | " + spot8 + " | " + spot9);

          Console.WriteLine();
          Console.WriteLine(currentName + " wins!");

          playing = false;
        }
        else if (turns == 9)
        {
          Console.Clear();

          Console.WriteLine(spot1 + " | " + spot2 + " | " + spot3);
          Console.WriteLine("--+---+--");
          Console.WriteLine(spot4 + " | " + spot5 + " | " + spot6);
          Console.WriteLine("--+---+--");
          Console.WriteLine(spot7 + " | " + spot8 + " | " + spot9);

          Console.WriteLine();
          Console.WriteLine("It's a tie!");

          playing = false;
        }
        else
        {
          // SWITCH PLAYER
          if (currentPlayer == "X")
          {
            currentPlayer = "O";
            currentName = player2;
          }
          else
          {
            currentPlayer = "X";
            currentName = player1;
          }
        }
      }
    }
  }
}