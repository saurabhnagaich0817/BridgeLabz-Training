using System;

class VotingCheck
{
    static void Main()
    {
        int[] ages = new int[10];

        // Taking input
        for (int i = 0; i < ages.Length; i++)
        {
            Console.Write("Enter age of student " + (i + 1) + ": ");
            ages[i] = int.Parse(Console.ReadLine());
        }

        // Checking voting eligibility
        for (int i = 0; i < ages.Length; i++)
        {
            if (ages[i] < 0)
            {
                Console.WriteLine("Invalid age");
            }
            else if (ages[i] >= 18)
            {
                Console.WriteLine("The student with the age " + ages[i] + " can vote");
            }
            else
            {
                Console.WriteLine("The student with the age " + ages[i] + " cannot vote");
            }
        }
    }
}
