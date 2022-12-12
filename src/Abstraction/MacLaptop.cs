using System;

namespace InheritanceEx
{
  public class MacLaptop : Laptop  
  {
    public override bool TouchScreen => false;

    public override string Name => "LAPTOP";

    //public bool LED = true;

    public override void Display()
    {
      Console.WriteLine("Displaying The Broadcast in MacBook");
    }
    

    public override void TurnOn()
    {
      Console.WriteLine("Turning On MacBook from Subclass");
    }
  }
}