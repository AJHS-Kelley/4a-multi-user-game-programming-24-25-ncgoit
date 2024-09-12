using System;
class Template {
  static void Main() {








































    int day = 1;
    switch(day)
    {
        case 1:
          Console.WriteLine("It's Monday.\n");
          break;
      
        case 2:
          Console.WriteLine("It's Tuesday.\n");
          break;
        case 3:
          Console.WriteLine("It's Wednesday.\n");
          break;
        case 4:
          Console.WriteLine("It's Thursday.\n");
          break;
        case 5:
          Console.WriteLine("It's Friday.\n");
          break;
        case 6:
          Console.WriteLine("It's Saturday.\n");
          break;
        case 7:
          Console.WriteLine("It's Sunday, go rest.\n");
          break;

    }


    // REPEATING STEPS OVER, AND OVER, AND OVER AGAIN
    // LOOPS are used to repeat instructions multiple times.

    // while Loops are 'musical chairs' in computer science.
    // the code will run as long as the condition is true.
    //while loop syntax:
    /*
    while (CONDITIONAL_EXPRESSION)
    {
        Code to loop goes here.
    }
    */

    // int z = 0;
    // while (z < 100) // What do I replace CONDTIONAL_EXPRESSION with?
    // {
    //   Console.WriteLine(z);
    //   z++;
    // }
    
    int y = 100;
    while (y >= 0) // What do I replace CONDTIONAL_EXPRESSION with?
    {
      Console.WriteLine(y);
      y--;
    }
  }
}