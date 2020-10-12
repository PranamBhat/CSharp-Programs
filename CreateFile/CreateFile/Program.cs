/*
 * C# Program to Create a File
 */
using System;
using System.IO;
using System.Text;
class Test
{
    public static void Main()
    {
        string textpath = @"E:\Pranam\Git Repository Projects\CSharp-Programs\pranam-test.txt";
        using (FileStream fs = File.Create(textpath))
        {
            Byte[] info = new UTF8Encoding(true).GetBytes("File is Created");
            fs.Write(info, 0, info.Length);
        }
        using (StreamReader sr = File.OpenText(textpath))
        {
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
        Console.Read();
    }
}