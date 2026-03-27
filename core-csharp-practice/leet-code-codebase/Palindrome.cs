using System;
class Palindrome
{
  static void Main(string[] args)
  {
      string str = "madam";
      string rev = "";

      for(int i =str.Length-1;i>= 0;i--)
      {
          rev += str[i];
      }

      if (str == rev)
      {
          Console.WriteLine(str + "is a palindrome.");
      }
      else
      {
          Console.WriteLine(str + "is not a palindrome.");
      }
  }
}
