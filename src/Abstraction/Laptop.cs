using System;

namespace InheritanceEx
{

    public abstract class Laptop
    {
        // abstract class can have constructor
        public Laptop()
        {
            Console.WriteLine("This is laptop");
        }
        // if virtual then CAN be inhertied by sub class
        public virtual void TurnOn()
        {
            Console.WriteLine("Turning On");
        }

        // if abstract then MUST be inherited by sub class
        public abstract void Display();

        // if nothing then CAN'T be iinheited by the sub class
        public void TurnOff()
        {
            Console.WriteLine("Turning Off");
        }

        public abstract bool TouchScreen { get; }
        public bool LED { get; set; }
        public abstract string Name { get; }

    }
}