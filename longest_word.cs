//Have the function LongestWord(sen) take the sen parameter being passed
//and return the longest word in the string.
//If there are two or more words that are the same length,
//return the first word from the string with that length.
//Ignore punctuation and assume sen will not be empty.
//Words may also contain numbers, for example "Hello world123 567"

using System;
using System.Text;

class MainClass {

  public static string LongestWord(string sen) {

    var biggestWord = "";
    var senRemovedNonLetters = RemoveNonLetters(sen);

    string[] words = senRemovedNonLetters.Split(' ');

    foreach(var word in words)
    {
      if(word.Length > biggestWord.Length)
      {
        biggestWord = word;
      }
    }
    sen = biggestWord;
    return sen;
  }

  public static string RemoveNonLetters(string str)
  {
    StringBuilder sb = new StringBuilder();
    foreach(char variable in str)
    {
      if(char.IsLetterOrDigit(variable) || 
      variable == ' ')
      {
        sb.Append(variable);
      }
    }
    return sb.ToString();
  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(LongestWord(Console.ReadLine()));
  } 
}
