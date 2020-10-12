/*
 * C# Program to Print the Sum of all the Multiples of 3 and 5
 */
using System;
using System.IO;
class Program
{
    static void Main()
    {
        File.Copy("test1.txt", "test2.txt");
        Console.WriteLine(File.ReadAllText("test1.txt"));
        Console.WriteLine(File.ReadAllText("test2.txt"));
        Console.Read();
    }
}