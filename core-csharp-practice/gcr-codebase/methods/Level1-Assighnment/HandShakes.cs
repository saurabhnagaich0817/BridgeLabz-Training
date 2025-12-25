using System;
class Handshakes
{
  static int hand(int n)
    {
        return (n * (n - 1)) / 2;
    }
      static void Main()
    {
        Console.Write("Enter number of student: ");
        int student = Convert.ToInt32(Console.ReadLine());
// Calculating hand
        int handshakes =hand(student);
        Console.WriteLine("Maximum number of handshakes: " + handshakes);
    }
}
