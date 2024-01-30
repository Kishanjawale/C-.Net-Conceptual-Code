using System;

public class InvalidAgeException : Exception
{
    public InvalidAgeException(string msg):base(msg)
    {
    
    }

}
public class TestUserDefinedExcpetion
{
    static void validate(int age)
    {
        if(age< 18)
        {
            throw new InvalidAgeException("Sorry Age must be greater than 18");
        }
    }
    public static void Main(string[] arg)
    {
        try
        {
            validate(13);
        }
        catch(InvalidAgeException e)
        {
            Console.WriteLine(e);
        }
    }
}