using System;

class NumberAnalyse
{
    static bool IsPositive(int n) => n >= 0;
    static bool IsEven(int n) => n % 2 == 0;
// comparing two numbers
    static int Compare(int a, int b){
        if(a > b) return 1;
        if(a == b) return 0;
        return -1;
    }
    static void Main(){
        int[] arr = new int[5];

        for(int i = 0; i < arr.Length; i++){
            Console.Write("Enter number: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());

            if(IsPositive(arr[i]))
                Console.WriteLine(IsEven(arr[i]) ? "Positive Even" : "Positive Odd");
            else
                Console.WriteLine("Negative");
        }
        int res = Compare(arr[0], arr[4]);
        Console.WriteLine(res == 0 ? "Equal" : res > 0 ? "First Greater" : "First Smaller");
    }
}
