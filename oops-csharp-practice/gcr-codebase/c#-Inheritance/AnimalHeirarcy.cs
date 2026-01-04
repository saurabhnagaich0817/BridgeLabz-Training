using System;


namespace AnimalHierarchy
{
    class Creature
    {
        public string label;
        public int lifeSpan;

        public Creature(string label, int lifeSpan)
        {
            this.label = label;
            this.lifeSpan = lifeSpan;
        }

        public virtual void SoundAction()
        {
            Console.WriteLine("Animal make a sound");
        }
    }

    class CanineType : Creature
    {
        public CanineType(string label, int lifeSpan) : base(label, lifeSpan) { }

        public override void SoundAction()
        {
            Console.WriteLine("Name : " + label);
            Console.WriteLine("Age  : " + lifeSpan);
            Console.WriteLine("Dog barks");
        }
    }

    class FelineType : Creature
    {
        public FelineType(string label, int lifeSpan) : base(label, lifeSpan) { }

        public override void SoundAction()
        {
            Console.WriteLine("Name : " + label);
            Console.WriteLine("Age  : " + lifeSpan);
            Console.WriteLine("Cat meow");
        }
    }

    class AvianType : Creature
    {
        public AvianType(string label, int lifeSpan) : base(label, lifeSpan) { }

        public override void SoundAction()
        {
            Console.WriteLine("Name : " + label);
            Console.WriteLine("Age  : " + lifeSpan);
            Console.WriteLine("Birds chrips");
        }
    }

    class AnimalRunner
    {
        static void Main(string[] args)
        {
            Creature[] list = new Creature[3];

            list[0] = new CanineType("Sheru", 3);
            list[1] = new FelineType("Kalu billa", 2);
            list[2] = new AvianType("Chidiya", 1);

            foreach (Creature item in list)
            {
                item.SoundAction();
                Console.WriteLine();
            }
        }
    }
}