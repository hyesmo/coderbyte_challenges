//Have the function BracketMatcher(str) take the str parameter being passed and return 1 if the brackets are correctly matched and each one is accounted for.
//Otherwise return 0. For example: if str is "(hello (world))", then the output should be 1
//but if str is "((hello (world))" the the output should be 0 because the brackets do not correctly match up.
//Only "(" and ")" will be used as brackets. If str contains no brackets return 1. 

using System;

class MainClass {

  public static string BracketMatcher(string str) {

    var a = 0;

    for(int i=0; i< str.Length; i++)
    {
      if(str[i] == '(')
      {
        a++;
      }
      else if(str[i] == ')')
      {
        a--;
      }
      if(a<0){
        return "0";
      }
    }
    
    if(a == 0){
      return "1";
    } else{
      return "0";
    }
  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(BracketMatcher(Console.ReadLine()));
  } 

}
