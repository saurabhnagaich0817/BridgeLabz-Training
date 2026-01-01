using System;

class Utility
{
    static void Main()
    {
        int userOption;

        do
        {
            Console.WriteLine("\n=== Math Utility Tool ===");
            Console.WriteLine("1. Factorial");
            Console.WriteLine("2. Prime Check");
            Console.WriteLine("3. GCD");
            Console.WriteLine("4. Fibonacci");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            userOption = Convert.ToInt32(Console.ReadLine());

            switch(userOption)
            {
                case 1:
                    Console.Write("Enter a number: ");
                    int inputValue = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Factorial = " + CalculateFactorial(inputValue));
                    break;

                case 2:
                    Console.Write("Enter a number: ");
                    int checkValue = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(CheckPrime(checkValue) ? "Prime Number" : "Not Prime");
                    break;

                case 3:
                    Console.Write("Enter first number: ");
                    int firstValue = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    int secondValue = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("GCD = " + FindGCD(firstValue, secondValue));
                    break;

                case 4:
                    Console.Write("Enter n: ");
                    int position = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Fibonacci(" + position + ") = " + GenerateFibonacci(position));
                    break;

                case 5:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while(userOption != 5);
    }

    // ===================== METHODS =====================

    static int CalculateFactorial(int number)
    {
        if(number < 0)
        {
            Console.WriteLine("Factorial not defined for negative numbers.");
            return -1;
        }

        int factorialResult = 1;
        for(int counter = 1; counter <= number; counter++)
        {
            factorialResult *= counter;
        }
        return factorialResult;
    }

    static bool CheckPrime(int number)
    {
        if(number <= 1)
            return false;

        for(int divisor = 2; divisor < number; divisor++)
        {
            if(number % divisor == 0)
                return false;
        }
        return true;
    }

    static int FindGCD(int valueOne, int valueTwo)
    {
        if(valueOne < 0) valueOne = -valueOne;
        if(valueTwo < 0) valueTwo = -valueTwo;

        while(valueTwo != 0)
        {
            int remainder = valueTwo;
            valueTwo = valueOne % valueTwo;
            valueOne = remainder;
        }
        return valueOne;
    }

    static int GenerateFibonacci(int index)
    {
        if(index < 0)
        {
            Console.WriteLine("Fibonacci not defined for negative numbers.");
            return -1;
        }

        if(index == 0) return 0;
        if(index == 1) return 1;

        int previous = 0;
        int current = 1;
        int nextValue = 0;

        for(int step = 2; step <= index; step++)
        {
            nextValue = previous + current;
            previous = current;
            current = nextValue;
        }
        return nextValue;
    }
}
