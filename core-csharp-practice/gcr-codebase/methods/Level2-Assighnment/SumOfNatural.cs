using System;

class SumOfNatural
{
static int RecursiveSum(int n){
        if(n == 0) return 0;
        return n + RecursiveSum(n - 1);
    }
    static int FormulaSum(int n){
        return n *(n + 1) / 2;
    }
    static void Main(){
        Console.Write("Enter n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if(n <= 0){
            Console.WriteLine("Not a natural number");
            return;
        }

        int rSum = RecursiveSum(n);
        int fSum = FormulaSum(n);

        Console.WriteLine("Recursive Sum: " + rSum);
        Console.WriteLine("Formula Sum: " + fSum);
        Console.WriteLine("Both results are equal: " +(rSum == fSum));
    }
}
