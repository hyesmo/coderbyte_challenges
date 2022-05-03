//Have the function FirstFactorial(num) take the num parameter being passed and return the factorial of it.
//For example: if num = 4, then your program should return (4 * 3 * 2 * 1) = 24.
//For the test cases, the range will be between 1 and 18 and the input will always be an integer.

using System;

class MainClass {
  public static int FirstFactorial(int num) {
    int a = 1;
    for(int i=num; i>0; i--){
      a*=i;
    }  
    num = a;
    return num;

  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(FirstFactorial(Console.ReadLine()));
  } 
}
