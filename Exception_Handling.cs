using System;

namespace Myapp
{
    class ExceptionHandling
    {
        static void Main(string[] arg)
        {
            try
            {
                int [] iNumbers={1,2,3};
                Console.WriteLine(iNumbers[10]);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}