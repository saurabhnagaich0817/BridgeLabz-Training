using System;

class MaxHandshakes
{
  static void Main(){
      // taking input from user and declaring variables
        int nos;
        int handshakes;

        Console.Write("Enter number of students: ");
        nos = Convert.ToInt32(Console.ReadLine());
// maximum handshakes 
        handshakes = (nos *(nos-1))/2;
// max number of handshakes  
        Console.WriteLine( "The maximum number of handshakes is " + handshakes);
    }
}
