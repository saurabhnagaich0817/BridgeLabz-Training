using System;
 class DataTypes{
	 static void Main(String[]args){
		 //  Bool used to store true false
		bool s=true;
		Console.WriteLine("bool s is ="+s);
		// int it us used to store whole number 
		int age = 21;
        Console.WriteLine("int age = "+age);
		// long used to store very large whole numbers
        long pn= 7800733100;
        Console.WriteLine("long phoneNumber ="+pn);
		// short  used to store small whole numbers
		short sn =120;
        Console.WriteLine("short sn ="+sn);
		// byte  used to store very small numbers  from(0to255)
		byte l= 5;
        Console.WriteLine("byte l ="+l);
		//float used to store decimal values  f is compulsory
        float p=85.5f;
        Console.WriteLine("float percentage ="+p);
		// double used for large decimal values  it is more acurate than float 
		double ss=4500.8;
		Console.WriteLine("double value is =" +ss);
		// char is used to sore single and it is written i single quates
		char g='s';
		Console.WriteLine("char vauen is=" +g);  
		
	// Type Conversion 
		//int to double //
		int a=10;
		double b=a;
		Console.WriteLine("value of a in double ="+b.ToString("0.0"));
	//	double to int
	  double x=46.66;
	  int y=(int)x;
	  Console.WriteLine("Value of double to int=" +y);
	  // char to int
	  char c='s';
	  int cc=c;
	  Console.WriteLine("value of char to int="+cc);
	  
	 
	  
	 }
 }