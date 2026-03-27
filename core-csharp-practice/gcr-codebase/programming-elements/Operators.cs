using System;

class Operators
{
    //simple variables
    static int a = 10;
    static int b = 5;

    static void Main(string[] args)
    {
        // Arithmetic operators
       
        Console.WriteLine("Arithmetic Operators");
        Console.WriteLine("a+b ="+(a+b)); //  for addition
        Console.WriteLine("a-b ="+(a-b)); // for  subtraction
        Console.WriteLine("a*b ="+(a*b)); //  for multiplication
        Console.WriteLine("a/b ="+(a/b)); //  for division
        Console.WriteLine("a%b ="+(a%b));   //  for remainder

        // Relational operators
        // Used to compare values
        Console.WriteLine("\nRelational Operators");
        Console.WriteLine("a>b = " + (a>b)); // greater than
        Console.WriteLine("a< b= " +(a<b));// less than
        Console.WriteLine("a==b =" +(a==b)); // equal
        Console.WriteLine("a !=b= " + (a !=b));//  if not equal

        // Logical operators
      
        Console.WriteLine("\nLogical Operators");
        Console.WriteLine("a >0 && b> 0 =" + (a > 0 && b > 0)); //  if both true
        Console.WriteLine("a>0||b>0="+(a>0||b>0)); //  if any one true
        Console.WriteLine("!(a>b) ="+!(a>b));              // if reverse result

        // Assignment operators
        Console.WriteLine("\nAssignment Operators");
        int c = a;// value assign
        c+=b;// add and store
        Console.WriteLine("c+=b="+c);
        c -=b;// subtract and store
        Console.WriteLine("c -= b = " + c);

        // Unary operators
        Console.WriteLine("\nUnary Operators");
        Console.WriteLine("++a ="+(++a));   // it increase by 1
        Console.WriteLine("--b="+(--b));   //  it decrease by 1
		
		
		// Ternary operator
        
        Console.WriteLine("\nTernary Operator");
        string res =(a>b)?"a is bigger":"b is bigger";
        Console.WriteLine(res);
		
	    Console.WriteLine("\nis Operator");
        Operators obj = new Operators(); // class instance
        Console.WriteLine(obj is Operators); // returns true
		
    }
}
