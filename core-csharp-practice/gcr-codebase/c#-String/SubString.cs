using System;
class SubStirng
{
  static void Main()
  {
      Console.WriteLine("Enter string:");
      string s=Console.ReadLine();

     Console.WriteLine("Enter start index:");
     int strt =int.Parse(Console.ReadLine());
     
        Console.WriteLine("Enter end index:");
        int end=int.Parse(Console.ReadLine());
      Console.WriteLine("Substring using method is:"+find(s,strt,end));
      Console.WriteLine("substring using built-in method is:"+s.Substring(strt,end-strt+1));
  }
  static string find(string s,int strt,int end)
  {
    string res="";
    for(int i = strt; i < end + 1; i++)
    {
      res+=s[i];
    }
    return res;
  }

}