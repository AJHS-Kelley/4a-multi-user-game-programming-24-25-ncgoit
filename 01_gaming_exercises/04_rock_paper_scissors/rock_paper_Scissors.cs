using System;
class Template
{
  static void Main() 
  {
    string playerName = "Test Player";
    // Player and CPU score.
    int playerScore;
    int cpuScore;
    // Player and CPU variable to store choices.
    int playerChoice;
    int cpuChoice;
    // Allow player to input their name.
    Console.Writeline("Enter your name:");
    playerName = Console.Readline();
    // Output game rules.
    Console.Writeline("Welcome, " + playerName + "! Let's play Rock, Paper, Scissors.");
    Console.Writeline("Rules:")
    Console.Writeline("Rock beats Scissors, Scissors beats Paper, and Paper beats Rock.")
    Console.Writeline("The first player to score 5 points wins.");
    // Random number generator for CPU
    Random random = new Random();
    while (playerScore < 5 && cpuScore < 5)
    {
      // Display choices and ask for player input.
      Console.Writeline("\nChoose: 1 for Rock, 2 for Paper, 3 for Scissors.");
      playerChoice = Convert.ToInt32(Console.Readline());
      // Generate a random Number between 1 and 3 for CPU choice.
      cpuChoice = random.Next(1,4);
      // Display choices
      Console.Writeline(playerName + "chose: " + ChoiceToString(playerChoice));
      Console.Writeline("CPU chpse: " + ChoiceToString(cpuChoice));
      // Determine winner
      if (playerChoice == cpuChoice)
    {
      Console.Writeline("It's a tie! No points awarded.");
    }
      else if ((playerChoice == 1 && cpuChoice == 3) || // Rocks beats Scissors
      (playerChoice == 2 && cpuChoice == 1) || // Paper beats Rock
      (playerChoice == 3 && cpuChoice == 2)) || // Scissors beats Paper
    {
      Console.Writeline(playerName + " wins this round!");
      playerScore++;
    }
    else
    {
      Console.Writeline("CPU wins this round!");
      cpuScore++;
    }
    // Display current score
    Console.Writeline(playerName + " Score: " + playerScore);
    Console.Writeline("CPU Score: " + cpuScore);
  }

    // Announce overall winner
    if (playerScore == 5)
    {
      Console.Writeline(playerName + " wins the game!");
    }
    else
    {
      Console.Writeline("CPU wins the game!");
    }
  }
  // Function to convert the number choice into a string.
  static string ChoiceToString(int choice)
  {
    switch (choice)
    {
      case 1:
        return "Rock";
      case 2:
        return "Paper";
      case 3:
        return "Scissors";
      default:
          return "Invalid choice";
    }
  }
}