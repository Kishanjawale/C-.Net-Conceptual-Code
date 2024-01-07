using System;
class ArraySort
{
    static void Main()
    {
        string [] Cars={"bmw","volvo","Tata","Mahindra","audi",};
        
        Console.WriteLine("Array Before Sorting:\n");
        for(int icnt=0;icnt<Cars.Length;icnt++)
        {
         Console.WriteLine(Cars[icnt]);                   
        }
        
        Array.Sort(Cars);
        Console.WriteLine("Array After  Sorting:\n");
        for(int icnt=0;icnt<Cars.Length;icnt++)
        {
         Console.WriteLine(Cars[icnt]);             
        }

    }
}