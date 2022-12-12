using System;

namespace InheritanceEx
{
  public class WindowsLaptop : Laptop
  {
    public override bool TouchScreen => true;

    public override string Name {
      get;
    }

     public override void Display()
    {
      Console.WriteLine("Displaying The Broadcast in Windows");
    }
  }
}