using System;

class Template {
  static void Main() {
    // Player variables.
    string playerName = "Test Player";
    int playerScore = 0;
    int playerChoice = "";

    // CPU variables.
    int cpuScore = 0;
    int cpuChoice = "";

    Console.WriteLine("Welcome! Let's play Rock, Paper, Scissors.\n");
    Console.WriteLine("Please type your name and press ENTER.\n");
    playerName = Console.ReadLine();
    Console.WriteLine("Hello {playerName}. Is that correct?\n");
    Console.WriteLine("Please type yes or no, then press enter.\n");
    string isCorrect = Console.ReadLine();

    if (isCorrect == "yes")
    {
      Console.WriteLine($"Great! I'll call you {playerName}.\n");
    }
    else if (isCorrect == "no")
    {
      Console.WriteLine("Please type your name and press ENTER.\n");
      playerName = Console.ReadLine();
    }
    else
    {
      Console.WriteLine("Unable to determine your answer. Try again.\n");
    }

    Console.WriteLine("""
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
      Console.WriteLine($"Your Score: {playerScore}\nCPU Score: {cpuScore}\n");

      // Let player choose R, P, S.
      Console.WriteLine("Please choose rock, paper, or scissors. Type your answer and press enter.\n");
      if (playerChoice != "rock" && playerChoice != "paper" && playerChoice != "scissors")
      {
        Console.WriteLine("Please choose rock, paper, or scissors. Type your answer and press enter.\n");
        playerChoice = Console.ReadLine().ToLower();
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
        Console.WriteLine("Unable to determine CPU choice.\n")
      }
      Console.WriteLine("CPU Choice" + cpuChoice)

      // Compare two choices
      if (playerChoice == "rock" && cpuChoice == "paper")
      Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
      Console.WriteLine("The CPU wins.\n");
      cpuScore++
      }
      else if (playerChoice == "rock" && cpuChoice == "scissors")
      {
        Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.WriteLine("You win!\n");
        playerScore++
      }
      else if (playerChoice == "rock" && cpuChoice == "rock")
      {
        Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.WriteLine("It's a draw!\n");
      }
      else if (playerChoice == "paper" && cpuChoice == "paper")
      {
        Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.WriteLine("It's a draw!\n");
      }
      else if (playerChoice == "paper" && cpuChoice == "scissors")
      {
      Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
      Console.WriteLine("The CPU wins.\n");
      cpuScore++
      }
      else if (playerChoice == "paper" && cpuChoice == "rock")
      {
        Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.WriteLine("You win!\n");
        playerScore++
      }
      else if (playerChoice == "scissors" && cpuChoice == "paper")
      {
        Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.WriteLine("You win!\n");
        playerScore++
      }
      else if (playerChoice == "scissors" && cpuChoice == "scissors")
      {
        Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.WriteLine("It's a draw!\n");
      }
      else if (playerChoice == "scissors" && cpuChoice == "rock")
      {
      Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
      Console.WriteLine("The CPU wins.\n");
      cpuScore++
    }
    
    if (playerScore > cpuScore)
    {
      Console.WriteLine("Congratulations, you are the winner!\n");
    }
    else
    {
      Console.WriteLine("The CPU has defeated you.\n");
    }
  }
}

