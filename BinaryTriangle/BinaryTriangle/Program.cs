/*
 * C# Program to Print a BinaryTriangle
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryTriangle
{
    class Program
    {
        public static void Main(String[] args)
        {
            int p, lastInt = 0, input;
            Console.WriteLine("Enter the Number of Rows : ");
            input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                for (p = 1; p <= i; p++)
                {
                    if (lastInt == 1)
                    {
                        Console.Write("0");
                        lastInt = 0;
                    }
                    else if (lastInt == 0)
                    {
                        Console.Write("1");
                        lastInt = 1;
                    }
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}