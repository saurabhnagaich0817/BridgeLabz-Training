using System;
class CountDownFor
{
  static void Main()
  {
      //  take user input create a variable no
    Console.WriteLine("Enter the number");
    int no=int.Parse(Console.ReadLine());
    //  countdown from number to 1
    for(int i = no; i >= 1; i--)
    {
      Console.WriteLine(i);

    }
  }
}