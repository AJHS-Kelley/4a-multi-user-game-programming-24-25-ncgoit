using System;
class Template {
  static void Main() {
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

    }
  }
}