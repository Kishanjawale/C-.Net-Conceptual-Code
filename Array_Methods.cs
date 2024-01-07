using System;
using System.Linq;
namespace MyApplication
{
   class ArrayMethods
    {
        static void Main()
        {
            int [] Numbers={10,5,25,20,51,26};
            Console.WriteLine("Largest Number:"+Numbers.Max());
            Console.WriteLine("Smallest  Number:"+Numbers.Min());
            Console.WriteLine("Summation Number:"+Numbers.Sum());

        }
    }
}