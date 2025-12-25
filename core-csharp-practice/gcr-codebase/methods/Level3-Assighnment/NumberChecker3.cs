using System;

class NumberChecker3
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int count = CountDigits(number);
        int[] digits = StoreDigits(number, count);
        int[] revDigits = revigits(digits);

        Console.WriteLine("Count of Digits: " + count);

        Console.Write("Digits Array: ");
        DisplayArray(digits);

        Console.Write("rev Digits Array: ");
        DisplayArray(revDigits);

        Console.WriteLine("Are Both Arrays Equal: " + compare(digits, revDigits));

        Console.WriteLine("Is Palindrome Number: " + IsPalindrome(digits, revDigits));

        Console.WriteLine("Is Duck Number: " + duck(digits));
    }

    // a. Count digits
    public static int CountDigits(int number)
    {
        int count = 0;
        while(number > 0)
        {
            count++;
            number /= 10;
        }
        return count;
    }

    // a. Store digits in array
    public static int[] StoreDigits(int number, int count)
    {
        int[] digits = new int[count];
        for(int i = count - 1; i >= 0; i--)
        {
            digits[i] = number % 10;
            number /= 10;
        }
        return digits;
    }

    // b. Reverse digits array
    public static int[] revigits(int[] digits)
    {
        int[] rev = new int[digits.Length];
        for(int i = 0; i < digits.Length; i++)
        {
            rev[i] = digits[digits.Length - 1 - i];
        }
        return rev;
    }

    // c. Compare two arrays
    public static bool compare(int[] arr1, int[] arr2)
    {
        if(arr1.Length != arr2.Length)
            return false;

        for(int i = 0; i < arr1.Length; i++)
        {
            if(arr1[i] != arr2[i])
                return false;
        }
        return true;
    }

    // d. Palindrome check
    public static bool IsPalindrome(int[] original, int[] rev)
    {
        return compare(original, rev);
    }

    // e. Duck number check
    public static bool duck(int[] digits)
    {
        foreach(int d in digits)
        {
            if(d == 0)
                return true;
        }
        return false;
    }

    // Utility method to display array
    public static void DisplayArray(int[] arr)
    {
        foreach(int a in arr)
            Console.Write(a + " ");
        Console.WriteLine();
    }
}
