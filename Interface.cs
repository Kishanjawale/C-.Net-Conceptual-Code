using System;

//Interface Animal
interface Animal
{
    //Interface is completely abastract class which can 
    //contains only abstract methods or properties
    void AnimalSound(); //interface method
    void Run(); //interface method
}

//Class Dog implements the interface
class Dog:Animal
{
    //Here AnimalSound and Run are the implemented methods which 
    //are declared as abstract in interface Animal 

    public void AnimalSound()
    {
        Console.WriteLine("Dog Barks...");
    }
    
    public void Run()
    {
        Console.WriteLine("Dog Runs At speed of 45KMPH");
    }
}

class InterfaceExample
{
    static void Main(string[] arg)
    {
        Dog mydog= new Dog();
        mydog.AnimalSound();
        mydog.Run();
    }
}