//Have the function BracketCombinations(num) read num which will be an integer greater than or equal to zero, 
//and return the number of valid combinations that can be formed with num pairs of parentheses.
//For example, if the input is 3, then the possible combinations of 3 pairs of parenthesis, 
//namely: ()()(), are ()()(), ()(()), (())(), ((())), and (()()). 
//There are 5 total combinations when the input is 3, so your program should return 5.

using System;

class MainClass {

  public static int BracketCombinations(int num) {

    double a = Faktoriyel(2*num)/(Faktoriyel(num)*Faktoriyel(num+1));
    return (int)a;
  }

  static double Faktoriyel(int num){
    double a = 1;
    for(int i = num; i>0; i--){a*=i;}
    return a;
  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(BracketCombinations(Console.ReadLine()));
  } 
}
