using System;

class Template {
  static void Main() {
    // Player variables.
    string playerName = "Test Player";
    int playerScore = 0;
    int playerChoice;

    // CPU variables.
    int cpuScore = 0;
    int cpuChoice = "";

    Console.Writeline("Welcome! Let's play Rock, Paper, Scissors.\n");
    Console.Writeline("Please type your name and press ENTER.\n");
    playerName = Console.Readline();
    Console.Writeline("Hello {playerName}. Is that correct?\n");
    Console.Writeline("Please type yes or no, then press enter.\n");
    string isCorrect = Console.Readline();

    if (isCorrect == "yes")
    {
      Console.Writeline($"Great! I'll call you {playerName}.\n");
    }
    else if (isCorrect == "no")
    {
      Console.Writeline("Please type your name and press ENTER.\n");
      playerName = Console.Readline();
    }
    else
    {
      Console.Writeline("Unable to determine your answer. Try again.\n");
    }

    Console.Writeline("""
    +===========================================================+
    |                                                           |
    |       WELCOME TO THE ROCK, PAPER, SCISSORS CHALLENGE!     |
    |                                                           |
    +===========================================================+
     You will select from Rock, Paper, or Scissors.
     The CPU will select one of those choices at random.
     Then a winner will be determined using the following rules:
     -- Rock Beats Scissors
     -- Paper Beats Rock 
     -- Scissors Beats Paper 

    The winner will receive a point.
    The first player to score 5 points will be declared the winner.
    """);
  



    while (playerScore < 5 && cpuScore < 5)
    {
      //Display choices and ask for player input.
      Console.Writeline($"Your Score: {playerScore}\nCPU Score: {cpuScore}\n");

      // Let player choose R, P, S.
      Console.Writeline("Please choose rock, paper, or scissors. Type your answer and press enter.\n");
      if (playerChoice != "rock" && playerChoice != "paper" && playerChoice != "scissors")
      {
        Console.Writeline("Please choose rock, paper, or scissors. Type your answer and press enter.\n");
        playerChoice = Console.Readline().ToLower();
      }

      // allow CPU to select randomly.
      Random rnd = new Random();
      int cpuRand = rnd.Next(0,2);

      if (cpuRand == 0)
      {
        cpuChoice = "rock";
      }
      else if (cpuRand == 1)
      {
        cpuChoice = "paper";
      }
      else if (cpuRand == 2)
      {
        cpuChoice = "scissors";
      }
      else
      {
        Console.Writeline("Unable to determine CPU choice.\n")
      }
      Console.Writeline("CPU Choice" + cpuChoice)

      // Compare two choices
      if (playerChoice == "rock" && cpuChoice == "paper")
      Console.Writeline($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
      Console.Writeline("The CPU wins.\n");
      cpuScore++
      }
      else if (playerChoice == "rock" && cpuChoice == "scissors")
      {
        Console.Writeline($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.Writeline("You win!\n");
        playerScore++
      }
      else if (playerChoice == "rock" && cpuChoice == "rock")
      {
        Console.Writeline($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.Writeline("It's a draw!\n");
      }
      else if (playerChoice == "paper" && cpuChoice == "paper")
      {
        Console.Writeline($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.Writeline("It's a draw!\n");
      }
      else if (playerChoice == "paper" && cpuChoice == "scissors")
      {
      Console.Writeline($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
      Console.Writeline("The CPU wins.\n");
      cpuScore++
      }
      else if (playerChoice == "paper" && cpuChoice == "rock")
      {
        Console.Writeline($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.Writeline("You win!\n");
        playerScore++
      }
      else if (playerChoice == "scissors" && cpuChoice == "paper")
      {
        Console.Writeline($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.Writeline("You win!\n");
        playerScore++
      }
      else if (playerChoice == "scissors" && cpuChoice == "scissors")
      {
        Console.Writeline($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.Writeline("It's a draw!\n");
      }
      else if (playerChoice == "scissors" && cpuChoice == "rock")
      {
      Console.Writeline($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
      Console.Writeline("The CPU wins.\n");
      cpuScore++
    }
    
    if (playerScore > cpuScore)
    {
      Console.Writeline("Congratulations, you are the winner!\n");
    }
    else
    {
      Console.Writeline("The CPU has defeated you.\n");
    }
  }
}

