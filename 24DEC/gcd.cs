using System;
class Program
{
  static void Main()
   {
  // initialize a variable
      int a=int.Parse(Console.ReadLine());
       int b=int.Parse(Console.ReadLine());
       Console.WriteLine("the greatest commmon factor of {0}and{1} is{2}",a,b,gcd(a,b));
   }
   static int gcd(int a, int b)
   {
	   // taking while loop 
	    while(b!=0){
           int temp =b;
           b = a % b;
           a = temp;
       }
       return a;
   }
}