//Have the function CodelandUsernameValidation(str) take the str parameter being passed
//and determine if the string is a valid username according to the following rules:

//1. The username is between 4 and 25 characters.
//2. It must start with a letter.
//3. It can only contain letters, numbers, and the underscore character.
//4. It cannot end with an underscore character.

//If the username is valid then your program should return the string true, otherwise return the string false.

using System;
using System.Text;

class MainClass {

  public static string CodelandUsernameValidation(string str) {

    var a = CheckCharset(str);

    if(a.Length < 4 || a.Length > 25)
    return "false";

    if(a[0] == '_' || char.IsDigit(a[0]))
    return "false";

    if(a[a.Length-1] == '_')
    return "false";
 
    return "true";

  }

  static string CheckCharset(string str){
    StringBuilder sb = new StringBuilder();

    foreach(char a in str){
      if(char.IsLetterOrDigit(a) || a == '_'){
        sb.Append(a);
      } else{
        return "a";
      }
    }

    return sb.ToString();
  }

  static void Main() {
    Console.WriteLine(CodelandUsernameValidation(Console.ReadLine()));
  }
}
