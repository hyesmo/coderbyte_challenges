//Have the function FirstReverse(str) take the str parameter being passed and return the string in reversed order.
//For example: if the input string is "Hello World and Coders"
//then your program should return the string sredoC dna dlroW olleH.

using System;

class MainClass {

  public static string FirstReverse(string str) {
    char[] charArray = str.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(FirstReverse(Console.ReadLine()));
  } 
}

