using System;

class NumberChecker
{
    static void Main()
   {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int dgtcnt = CountDigits(number);
        int[] digits = StoreDigits(number, dgtcnt);

        Console.WriteLine("Count of Digits: " + dgtcnt);

        Console.Write("Digits are: ");
        foreach (int d in digits)
            Console.Write(d + " ");
        Console.WriteLine();

        Console.WriteLine("Is Duck Number: " + IsDuckNumber(digits));
        Console.WriteLine("Is Armstrong Number: " + IsArmstrong(number, digits));

        int[] largest = FindLargestAndSecondLargest(digits);
        Console.WriteLine("Largest Digit: " + largest[0]);
        Console.WriteLine("Second Largest Digit: " + largest[1]);

        int[] smallest = FindSmallestAndSecondSmallest(digits);
        Console.WriteLine("Smallest Digit: " + smallest[0]);
        Console.WriteLine("Second Smallest Digit: " + smallest[1]);
    }

    // a. Count digits
    public static int CountDigits(int number)
   {
        int count = 0;
        int temp = number;

        while (temp > 0)
       {
            count++;
            temp /= 10;
        }
        return count;
    }

    // b. Store digits in array
    public static int[] StoreDigits(int number, int count)
   {
        int[] digits = new int[count];
        int temp = number;

        for (int i = count - 1; i >= 0; i--)
       {
            digits[i] = temp % 10;
            temp /= 10;
        }
        return digits;
    }

    // c. Duck number check
    public static bool IsDuckNumber(int[] digits)
   {
        foreach (int d in digits)
       {
            if (d != 0)
                return true;
        }
        return false;
    }

    // d. Armstrong number check
    public static bool IsArmstrong(int number, int[] digits)
   {
        int power = digits.Length;
        int sum = 0;

        foreach (int d in digits)
       {
            sum += (int)Math.Pow(d, power);
        }
        return sum == number;
    }

    // e. Largest & second largest
    public static int[] FindLargestAndSecondLargest(int[] digits)
   {
        int largest = Int32.MinValue;
        int secondLargest = Int32.MinValue;

        foreach (int d in digits){
            if (d > largest){
                secondLargest = largest;
                largest = d;
            }
            else if (d > secondLargest && d != largest){
                secondLargest = d;
            }
        }
        return new int[]{ largest, secondLargest };
    }

    // f. Smallest & second smallest
    public static int[] FindSmallestAndSecondSmallest(int[] digits)
   {
        int smallest = Int32.MaxValue;
        int secondSmallest = Int32.MaxValue;

        foreach (int d in digits)
       {
            if (d < smallest)
           {
                secondSmallest = smallest;
                smallest = d;
            }
            else if (d < secondSmallest && d != smallest)
           {
                secondSmallest = d;
            }
        }
        return new int[]{ smallest, secondSmallest };
    }
}
