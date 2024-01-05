/* Write a C# Sharp program to display the weather based on the
temperature in centigrade
If Temp < 10 diplay Freezing weather
otherwise print "Normal weather"
*/
using System;

class If_Else
{
    static void Main()
    {
        int iTemp =0;
        Console.WriteLine("Enter the Temperature");
        iTemp = Convert.ToInt32(Console.ReadLine());
        string  Result= (iTemp < 10) ? "Freezing weather " : "Normal weather";      
        Console.WriteLine(Result);
    }

}
