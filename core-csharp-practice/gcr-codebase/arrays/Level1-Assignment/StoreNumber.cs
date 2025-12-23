using System;
class StoreNumber{
  static void Main(){
        double[] no = new double[10];
        double total = 0.0;
        int index = 0;
        while(true)
        {
            Console.Write("Enter number: ");
            double num = double.Parse(Console.ReadLine());
// Stopping condition: negative number or array full
            if(num <= 0 || index == 10)
                break;
// Storing number in array
            no[index] = num;
            index++;
        }
// Displaying numbers and calculating sum
        for(int i = 0; i < index; i++)
        {
            total += no[i];
            Console.WriteLine(no[i]);
        }
// Displaying total sum
        Console.WriteLine("Sum = " + total);
    }
}
