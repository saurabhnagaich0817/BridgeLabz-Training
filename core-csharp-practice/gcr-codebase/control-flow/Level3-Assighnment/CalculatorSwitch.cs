using System;

class CalculatorSwitch
{
    static void Main()
    {
      // reading input from user
        Console.Write("Enter fst number: ");
        double fst = double.Parse(Console.ReadLine());
//      reading sc number from user
        Console.Write("Enter sc number: ");
        double sc = double.Parse(Console.ReadLine());
//     reading operator from user
        Console.Write("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine();

        switch (op)
        {   
        
            case "+":
                Console.WriteLine("Result = " + (fst + sc));
                break;

            case "-":
                Console.WriteLine("Result = " + (fst - sc));
                break;

            case "*":
                Console.WriteLine("Result = " + (fst * sc));
                break;

            case "/":
                if (sc!= 0)
                    Console.WriteLine("Result = " + (fst / sc));
                else
                    Console.WriteLine("Cannot divide by zero");
                break;

            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
