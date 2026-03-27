using System;
class CountDown
{
  static void Main()
  {
    //  take user input create a variable counter
    Console.Write("Enter a number to start countdown: ");
    int counter = int.Parse(Console.ReadLine());
  //  countdown from counter to 1
    while(counter > 1)
    {
        Console.WriteLine(counter);
        counter--;
    }
   
  }
}