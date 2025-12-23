using System;

class fact
{
    static void Main()
    {
        Console.Write("Enter num: ");
        int num = int.Parse(Console.ReadLine());

        int ms = 10;
        int[] fact = new int[ms];
        int idxx = 0;

        for(int i = 1; i <= num; i++)
        {
            if(num % i == 0)
            {
                if(idxx == ms)
                {
                    ms *= 2;
                    int[] temp = new int[ms];
                    for(int j = 0; j < fact.Length; j++)
                        temp[j] = fact[j];
                    fact = temp;
                }
                fact[idxx++] = i;
            }
        }
        Console.WriteLine("fact:");
        for(int i = 0; i < idxx; i++)
            Console.Write(fact[i] + " ");
    }
}
