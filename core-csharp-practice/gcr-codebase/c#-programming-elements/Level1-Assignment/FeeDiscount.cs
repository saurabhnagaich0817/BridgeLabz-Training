using System;
class FeeDiscount
{
  static void Main()
  {
    // Given values of  fee and discount percentage
    double fee= 125000;
    double discountpercentage=10;

    double dic=(fee*discountpercentage)/100;

    double finalfee= fee - dic;
    // output for final fees after discount
 Console.WriteLine( "The discount amount is INR " + dic + " and final discounted fee is INR " + finalfee);
      
  }
}