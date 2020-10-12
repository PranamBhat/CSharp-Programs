/*
 * C# Program to Create a Directory
 */
using System;
using System.IO;
class program
{
    public static void Main()
    {
        Directory.CreateDirectory("E:\\Test-Dir");
        Console.WriteLine("NewDirectory is Created in 'E' Directory");
        Console.ReadLine();

    }
}