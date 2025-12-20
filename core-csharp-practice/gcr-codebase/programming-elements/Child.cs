using System;

namespace ProgrammingElements
{
    class Child : Parent
    {
        public void ShowChild()
        {
            Console.WriteLine("Inside Child Class");

            Console.WriteLine(publicVar);
            Console.WriteLine(protectedVar);
            Console.WriteLine(internalVar);
            Console.WriteLine(protInternalVar);
        }
    }
}
