using System;
class QuatientRem{
    static void Main(){
        //  taking input from user
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());
//  
        Console.Write("Enter second number: ");
        // 
        int num2 = int.Parse(Console.ReadLine());
// calculating quotient and remainder
        int qt = num1 / num2;
        int rem = num1 % num2;
// displaying quotient and remainder
        Console.WriteLine("The qt is " + qt + " and Remainder is " + rem + " of two numbers " + num1 + " and " + num2);
    }
}
