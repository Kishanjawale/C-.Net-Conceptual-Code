using System.IO; //include The System IO namespace
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string [] arg)
        {

            // string filePath = "path/to/your/file.txt";
            // string content = File.ReadAllText(filePath);

            // string WriteText= "Hello World"; //Create a Text String


            // File.WriteAllText("filename.txt",WriteText);
            // string readText= File.ReadaAllText("filename.txt");
            // Console.WriteLine(readText);  
            
        try
        {
            string filePath = @"F:\New Start\C sharp dot net\FileIO.cs";
            string content = File.ReadAllText(filePath);
            Console.WriteLine(content);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }

        
        }
    }
}