/*
 * C# Program to View the Information of the File
 */
using System;
using System.IO;
class Program
{
    static void Main()
    {
        FileInfo info = new FileInfo("E:\\Pranam\\Git Repository Projects\\CSharp-Programs\\test.txt");
        FileAttributes attributes = info.Attributes;
        Console.WriteLine("Nature(Attribute) of the File : {0}", attributes);
        Console.Read();
    }
}