using System;
class ProfitLoss
{
  static void Main() { 
      //  value of cp and sp
    double costprice = 129;
    double sellingprice = 191;
    // now calculating the profit and profit  percentage 
    double profit = sellingprice - costprice;
    double profitPercentage = (profit / costprice) * 100;
    // now displaying the statement with multiple line  output
   Console.WriteLine( "The Cost Price is INR " + costprice + " and Selling Price is INR " + sellingprice +"\nThe Profit is INR " + profit + " and the Profit Percentage is " + profitPercentage + "%");
    }

}