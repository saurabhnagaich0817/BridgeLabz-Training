using System;
class FeeDiscounts
{
  static void Main()
  {  

    // Taking input from user for fee and discount percentage
    double fee, discountPercent, discount, finalFee;
    //  reading input from user
     Console.Write("Enter Student Fee: ");
        fee = Convert.ToDouble(Console.ReadLine());
        // reading discount percentage
        Console.Write("Enter Discount Percentage: ");
        discountPercent = Convert.ToDouble(Console.ReadLine());
      //  calculating discount amount and final fee after discount
        discount = (fee * discountPercent) / 100;
        finalFee = fee - discount;
      //  output for final fees after discount
        Console.WriteLine( "The discount amount is INR " + discount +" and final discounted fee is INR " + finalFee);
  }
}