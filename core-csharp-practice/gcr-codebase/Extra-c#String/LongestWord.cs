using System;
class LongestWord
{
  static void Main()
  {
     Console.WriteLine("Enter a sentence:");
     string s=Console.ReadLine();
     string word ="";
     string Longest ="";
     for(int i = 0; i < s.Length; i++)
    {
      if (s[i] != ' ')
      {
        word+=s[i];
      }
      else
      {
        if(word.Length>Longest.Length)
        {
          Longest=word;
        }
        word="";
      }
    }
   Console.WriteLine("Longest word is: " + Longest);
  }
}