using System;

namespace ProgrammingElements
{
    class Program
    {
        static void Main()
        {
            Parent p = new Parent();
            Child c = new Child();
          Console.WriteLine("Inside Main Method");
            Console.WriteLine(p.publicVar);
            Console.WriteLine(p.internalVar);
            Console.WriteLine(p.protInternalVar);
            Console.WriteLine();
            p.ShowParent();
            Console.WriteLine();
            c.ShowChild();
        }
    }
}
