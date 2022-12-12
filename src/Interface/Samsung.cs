using System;

namespace InheritanceEx
{
    public class Samsung : Desktop
    {
        // no need of override keyword if it is interface
        
        public string Name {get; set;}
    
        public void TurnOn()
        {
            Console.WriteLine("Desktop On");
        }

        public void Display()
        {
            Console.WriteLine("Desktop Displaying");
        }

        public void TurnOff()
        {
            Console.WriteLine("Desktop Off");
        }
    }
}