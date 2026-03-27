using System;

class LYP3
{
    static void Main()
    {
      // reading marks input from user
        Console.Write("Enter Physics marks: ");
        int physics = int.Parse(Console.ReadLine());

        Console.Write("Enter Chemistry marks: ");
        int chemistry = int.Parse(Console.ReadLine());

        Console.Write("Enter Maths marks: ");
        int maths = int.Parse(Console.ReadLine());

        // Calculate average percentage
        double average = (physics + chemistry + maths) / 3.0;

        Console.WriteLine("Average Percentage = " + average);

        // Grade and Remarks as per table
        if (average >= 80)
            Console.WriteLine("Grade: A | Remarks: Level 4, above agency-normalized standards");
        else if (average >= 70)
            Console.WriteLine("Grade: B | Remarks: Level 3, at agency-normalized standards");
        else if (average >= 60)
            Console.WriteLine("Grade: C | Remarks: Level 2, below but approaching standards");
        else if (average >= 50)
            Console.WriteLine("Grade: D | Remarks: Level 1, well below standards");
        else if (average >= 40)
            Console.WriteLine("Grade: E | Remarks: Level 1-, too below standards");
        else
            Console.WriteLine("Grade: R | Remarks: Remedial standards");
    }
}
