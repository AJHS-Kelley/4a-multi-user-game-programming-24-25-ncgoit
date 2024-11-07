using System;
class Template {
  static void Main() {
    
  }
}
// Collections Example, , v0.0
// using System;
// using System.Linq;
// using System.Coleections;


// class 04_Collections {
//   static void Main() { // DO NOT DELETE!

//   /*
//   In C# an collection is known as an ARRAY.
//   -- EACH ITEM IN THE ARRAY IS AN ELEMENT
//   -- NUMBER OF ELEMENTS IN THE ARRAY CANNOT BE CHANGED.
//   -- CONTENTS OF EACH ELEMENT CAN CHANGE.
//   -- ARRAYS ARE ORDERED, MEANING EACH ITEM HAS A FIXED POSITION.
//   -- POSITION OF THE ELEMENT IS THE INDEX
//   -- FIRST ELEMENT INDEX IS 0.
//   */

//   DECLARING AND DEFINING AN ARRAY
//   string[] breakfastFoods = {"Bacon", "Eggs", "Cold Pizza", "Capn' Crunch",}
//   int[] testScore = {0, 25, 15, 75, 99};
//   double[] GPA = {0.27d, 1.99D, 4.02D, 0.0D, 3.25};

//   Print Array Contents -- All Elements on Single Line
//   Console.WriteLine("The elements of each array are:\n");
//   Console.WriteLine("breakfastFoods: \n" + String.Join (",", breakfastFoods));
//   Console.WriteLine(); // Print an empty line to the screen.
//  
// }
//  Print Array Contents -- All Elements on Single Line
//   Console.WriteLine("The elements of each array are:\n");
//   Console.WriteLine("breakfastFoods: \n" + String.Join ("\n", breakfastFoods));
//   Console.WriteLine(); // Print an empty line to the screen.
// How long is my array? DETERMINING ARRAY LENGHT 
//   Console.WriteLine("The length of the breakFastFoods array is:" + breakfastFoods);
//  .Lenght is known as PROPERTY of the array.

//   Accessing Elements in the array with the index.
//   Console.WriteLine("The first element is breakFastFoods is:" + breakFastFoods[0];)
//   PRINT THE 2nd ELEMENT OF THE testScores array.
//  PRINT THE 3rd ELEMENT OF THE GPA array.

//  Shortcut to Access Last Item in an Array
//  Console.WriteLine("The last element of breakFastFoods is:" + breakFastFoods[breakfastFoods.Lenght - 1]);
//  Console.WriteLine("The last element of testScores is: " + testScores[testScores.Length - 1]);

// CHANGING ELEMENTS IN THE ARRAY
// breakfastFoods[2] = "Green Eggs and Ham";
// testScores[0] = -1;
// GPA[1] = 4.0D;
// Console.WriteLine("The elements of each array are:\n");
// Console.WriteLine("breakFASTFoods: \n" + String.Join (",", breakfastFoods));
// Console.WriteLine(); // Print an empty line to the screen.
// */

// // COMMON ERRORS WITH ARRAYS
// Console.WriteLine(breakfastFoods[99]); // Index Out of Bounds -- Accessing index that does not exist in the array.

// //testScores[0] = "99"; // eRROR mESSAGE "Cannot implicity convert dataType to dataType"
// // Trying to put incorrect data type into the array.

//  // COMMON ARRAY METHODS -- Ways to work with the array data.
// // Sorting an Array
//  int[] intArr = {-25, 50, 68, 523, -1205, 99918582, -1, 55, 0, 124}
//   string[] zooAnimals = {"Monkey", "Zebra", "Elephant", "Moose", "Iguana"}; 
 
//  Array.Sort(intArr);
//   Array.Sort(zooAnimals);
//   // Array.Sort will sort string arrays ALPHABETTICALLY A-Z and numerical arrays from LEAST TO GREATEST
//    Console.WriteLine("The elements of each array are:\n");
//    Console.WriteLine("breakfastFoods: \n" + String.Join (",", breakfastFoods));
//    Console.WriteLine(); // Print an empty line to the screen.
  
//   // Finding the MIN, MAX, and SUM for numerical arrays.
//   Console.WriteLine("The MINIMUM value for intArr is:"+ intArr.Min());
//   Console.WriteLine("The MAXIMUM value for intArr is: " + intArr.Max()); 
//   Console.WriteLine("The SUM value for intArr is: " + intArr.Sum());


    // ArrayList --> Basically an array you can add/renove elements from.
    var exampleArrList = new ArrayList(); // Create an new ArrayList.
    // Adding elements to an ArrayList use .Add()
    // .Add() puts the item 
    exampleArrList.Add(5);
    exampleArrList.Add("Shrek 5: The Search for Donkey");
    exampleArrList.Add(false);
    exampleArrList.Add(1.25);

    // Create ArrayList with Values
    var exampleArrList2 = new ArrayList()
        {
            -10, "Last Name", "Purple", false, 25.25D, 195000, 0.0D
        }; 
    // Console.WriteLine(exampleArrList[2]);
    // Console.WriteLine(exampleArrList2[5]);

    // Inserting to a specific position in the ArrayList
    // Use .Insert(index, value)
    // exampleArrList.Insert(3,"Ogers are like onions.\n);
    //exampleArrList.Insert(0,-99);

    // .Remove(value) removes the FIRST OCCURENCE of the item from the ArrayList.
    var newList = new ArrayList()
    {
        -10, 10, 15, -25, 33, -25, 40
    };
    // Console.WriteLine(newList[0]);
    // newList.Remove(-10);
    // Console.WriteLine(newList[0]);

    // Deleting based on index number.
    // .RemoveAt(value) --> deletes the item at the specified index
    newList.RemoveAt(4);

    // Delete the First Item
    newList.RemoveAt(0);

    // Remove an entire range of elements.
    // .RemoveRange(firstIndexToDelete, LastIndexToDelete)
    newList.RemoveRange(3,8)

    // SHortcut to Delete from one item through the end of list.
    newList.RemoveRange(4, newList.Length -1);

    // Does the ArrayList contain a certain value.
    // .Contains(value) returns true if the list has that value, false otherwise.
    new playerInventory = new ArrayList()
    {
        "Sword", "Shield", "Bazooka", "1-up Power-Up", "Death Notebook", "Potato"
    };

    Console.WriteLine(playerInventory.Contains("Fishing Pole"));
    Console.WriteLine(playerInventory.Contains("Sword"));

    if (playerInventory.Contains("Blue Key"))
    {
        // Do something
    }


  } // DO NOT EVER, 3 SPACES INDENTED FROM LEFT
} // DO NOT DELETE EVER, ALWAYS TOUCHING LEFT MARGIN
