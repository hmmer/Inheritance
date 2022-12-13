using System;
using InheritanceEx;

class Program
{
    public static void Main(string[] args)
    {
        Laptop macBook = new MacLaptop();
        Laptop windows = new WindowsLaptop();

        Desktop samsung = new Samsung();

        Console.WriteLine("********** Abstraction ************");
        macBook.TurnOn();
        macBook.Display();
        macBook.TurnOff();
        Console.WriteLine(macBook.Name);
        Console.WriteLine(macBook.TouchScreen);

        Console.WriteLine("**********************");

        windows.TurnOn();
        windows.Display();
        windows.TurnOff();
        Console.WriteLine(windows.Name);
        Console.WriteLine(windows.TouchScreen);

        //macBook.LED = true;
        //Console.WriteLine(macBook.LED);

        //https://www.programiz.com/csharp-programming/abstract-class

        Console.WriteLine("********** Interface ************");

        samsung.TurnOn();
        samsung.Display();
        samsung.TurnOff();
        samsung.Name = "Desktop";
        Console.WriteLine(samsung.Name);
    }
}