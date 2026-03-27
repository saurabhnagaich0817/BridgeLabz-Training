using System;

class YoungestTall
{
    static void Main()
    {
      // Reading ages and heights of Amar, Akbar, and Anthony
        Console.Write("Enter Amar age: ");
        
        int amarage = int.Parse(Console.ReadLine());
        Console.Write("Enter Amar height: ");
        int amaheight = int.Parse(Console.ReadLine());
// Reading ages and heights of Amar, Akbar, and Anthony
        Console.Write("Enter Akbar age: ");
        int akbarage = int.Parse(Console.ReadLine());
        Console.Write("Enter Akbar height: ");
        int akbarht = int.Parse(Console.ReadLine());
// Reading ages and heights of Amar, Akbar, and Anthony
        Console.Write("Enter Anthony age: ");
        int anthonyAge = int.Parse(Console.ReadLine());
        Console.Write("Enter Anthony height: ");
        int anthonyHeight = int.Parse(Console.ReadLine());

        // Youngest
        if (amarage <= akbarage && amarage <= anthonyAge)
            Console.WriteLine("Amar is the youngest");
        else if (akbarage <= amarage && akbarage <= anthonyAge)
            Console.WriteLine("Akbar is the youngest");
        else
            Console.WriteLine("Anthony is the youngest");

        // Tallest
        if (amaheight >= akbarht && amaheight >= anthonyHeight)
            Console.WriteLine("Amar is the tallest");
        else if (akbarht >= amaheight && akbarht >= anthonyHeight)
            Console.WriteLine("Akbar is the tallest");
        else
            Console.WriteLine("Anthony is the tallest");
    }
}
