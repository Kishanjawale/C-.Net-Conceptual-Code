using System;
using System.IO;

public class File_Write_Operation
{
    public static void Main(string[] args)
    {
        FileStream fs = new FileStream("NewText.txt", FileMode.OpenOrCreate);

        for (int i = 65; i < 90; i++)
        {
            fs.WriteByte((byte)i);
        }
        fs.Close();
    }
}
