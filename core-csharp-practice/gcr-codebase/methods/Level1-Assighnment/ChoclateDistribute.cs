using System;

class ChocolateDistribute
{
  // Method to find remainder and quotient
    public static int[] findremquat(int choc, int childs)
    {
      // calculating choc for each child and remain choc
        int eachChild = choc / childs;
        int remain = choc % childs;
        return new int[] { eachChild, remain };
    }

    static void Main()
    {
        Console.Write("Enter number of choc: ");
        int choc = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of childs: ");
        int childs = Convert.ToInt32(Console.ReadLine());

        int[] result = findremquat(choc, childs);
        Console.WriteLine("Each child gets: " + result[0]);
        Console.WriteLine("remain choc: " + result[1]);
    }
}
