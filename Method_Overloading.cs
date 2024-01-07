using System;
namespace MyApplication
{
class MethodOverloading
{
    static int Addition(int iValue1,int iValue2)
    {
        return iValue1+iValue2;
    }
    static double Addition(double fValue1, double fValue2)
    {    
        return fValue1+fValue2;
    }

    static void Main(String [] arg)
    {
        int iAddition=Addition(5,10);
        double dAddition=Addition(4.5,5.577);

        Console.WriteLine("Integer Addition:"+iAddition);
        Console.WriteLine("Double Addition:"+dAddition);

    }
}
}