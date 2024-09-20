using System;
class GuessNumber {
  static void Main() {
    int numGuess = 0;
    int maxGuess = 5;
    int guess;
    
    // Generate the secret number here.
    Random rnd = new Random(); // Create an object named 'rnd' that is a copy of the Random() class
    int secretNumber = rnd.Next(101); // Generate from 0 to 100
    Console.WriteLine(secretNumber); // COMMENT OUT AFTER TESTING
    // int secretNumber = rnd.Next(25, 1000); // Generate from 25 to 999

   while (numGuess < maxGuess)
   {
       Console.WriteLine("Please guess an interger between 0 and 100.\n");        
       guess = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Guess" + guess);
       numGuess++;
       if (guess < secretNumber)
       {
          Console.WriteLine("Your guess is too low.\n");
       }
       else if (guess > secretNumber)
       {
          Console.WriteLine("Your guess is too high.\n");
       }
       else
       {
          Console.WriteLine("You guessed correctly!\n");
          break; // Keyword to immediately exit a loop.
       }

       if (numGuess >= maxGuess)
       {
          Console.WriteLine("You have lost the game.\nYour grandparents are disapointed in you.\n");
       }
   }
      // Allow the user to guess the number.
      // Compare the guess to the secret number.
      // If match, print win, if > or <, give a hint.
      // +1 to numGuess
      // Check if numGuess > maxGuesses.
      //If true, print a "lose game" message, if false guess again.
      

  }
}