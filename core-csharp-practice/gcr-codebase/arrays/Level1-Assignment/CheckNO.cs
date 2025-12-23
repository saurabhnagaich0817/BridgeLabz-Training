using System;

class NumberCheck
{
    static void Main()
    {
        int[] arr = new int[5];

        // Input
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        // Checking each number
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                if (arr[i] % 2 == 0)
                    Console.WriteLine(arr[i] + " is Positive Even");
                else
                    Console.WriteLine(arr[i] + " is Positive Odd");
            }
            else if (arr[i] < 0)
            {
                Console.WriteLine(arr[i] + " is Negative");
            }
            else
            {
                Console.WriteLine(arr[i] + " is Zero");
            }
        }

        // Compare first and last
        if (arr[0] == arr[4])
            Console.WriteLine("First and Last elements are Equal");
        else if (arr[0] > arr[4])
            Console.WriteLine("First element is Greater");
        else
            Console.WriteLine("Last element is Greater");
    }
}
