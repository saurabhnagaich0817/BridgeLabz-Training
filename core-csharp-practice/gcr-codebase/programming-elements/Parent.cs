using System;

namespace ProgrammingElements
{
    class Parent
    {
        public int publicVar = 10;
        private int privateVar = 20;
        protected int protectedVar = 30;
        internal int internalVar = 40;
        protected internal int protInternalVar = 50;

        public void ShowParent()
        {
            Console.WriteLine("Inside Parent Class");
            Console.WriteLine(publicVar);
            Console.WriteLine(privateVar);
            Console.WriteLine(protectedVar);
            Console.WriteLine(internalVar);
            Console.WriteLine(protInternalVar);
        }
    }
}
