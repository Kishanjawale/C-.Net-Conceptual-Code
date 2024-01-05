/* Write a C# Sharp program to display the weather based on the
temperature in centigrade
If Temp < 10 diplay Freezing weather
If Temp is between 10 and 20 then display Very Cold weather
If Temp is between Temp 21 and 30 then display Normal
Temperature
If Temp >30 then display Its Very Hot 
*/
using System;

class If_Else
{
    static void Main()
    {
        int iTemp =0;
        Console.WriteLine("Enter the Temperature");
        iTemp = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Temperature:"+iTemp);
        displayResult(iTemp);   
    }

    static void displayResult(int iTemperature)
    {
        if(iTemperature < 10)
        {
            Console.WriteLine("Freezing weather");
        }
        else if(iTemperature >= 10 && iTemperature <= 20 )
        {
            Console.WriteLine("Very cold weather.");
        }
        else if(iTemperature >= 21 && iTemperature <= 30 )
        {
            Console.WriteLine("Normal Temperature.");
        }
        else if (iTemperature > 30)
        {
            Console.WriteLine("Very Hot Temperature");
        }
    } 

}
