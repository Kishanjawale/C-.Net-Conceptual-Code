using System;

namespace Myapp
{
    class ExceptionHandling
    {
        static void Main(string[] arg)
        {
             # Try Block Contains Exception Prone code
            try
            {
                int [] iNumbers={1,2,3};
                Console.WriteLine(iNumbers[10]); //This will generate array index out of bound exception.    
            }
            catch(Exception e) //Catch block to catch the exception.
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
