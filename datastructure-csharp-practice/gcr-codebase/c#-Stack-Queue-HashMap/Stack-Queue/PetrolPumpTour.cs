using System;

class PetrolPumpTour
{
    static void Main()
    {
        int[] fuel = { 5, 8, 2, 6 };
        int[] distance = { 4, 3, 6, 5 };
        int currentFuel = 0;
        int shortage = 0;
        int startingPoint = 0;
      for(int index = 0; index < fuel.Length; index++)
        {
            currentFuel += fuel[index] - distance[index];

            if(currentFuel < 0)
            {
                shortage += currentFuel;
                startingPoint = index + 1;
                currentFuel = 0;
            }
        }
        if(currentFuel + shortage >= 0)
            Console.WriteLine(startingPoint);
        else
            Console.WriteLine(-1);
    }
}
