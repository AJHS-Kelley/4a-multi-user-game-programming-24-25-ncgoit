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
    
  }
}