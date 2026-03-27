using System;

class PurchasePrice{
   static void Main(){
        //  taking input from user and declaring variables
        double unitp;
        int qty;
        double tp;

        Console.Write("Enter unit price: ");
        unitp = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter qty: ");
        qty = Convert.ToInt32(Console.ReadLine());
// total purchase price 
        tp = unitp * qty;
// printing the result
        Console.WriteLine( "The total purchase price is INR " + tp +" if the quantity " + qty +" and unit price is INR " + unitp);
    }
}
