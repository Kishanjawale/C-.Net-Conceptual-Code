using System;

class Vehicle // Base Class
{
    public string Brand = "Audi";
    public void Top_speed()
    {
        Console.WriteLine("Top Speed : 280kmph\n");
    }
}

class Car : Vehicle // Derived Class (changed from Base to Vehicle)
{
    public string ModelName = "R8";
}

class Program // Corrected class name from Derived to Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.Top_speed();
        Console.WriteLine(myCar.Brand + "  " + myCar.ModelName);
    }
}
