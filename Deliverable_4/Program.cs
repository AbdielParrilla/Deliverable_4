// Author: Abdiel
// Date: 02/09/2023
// Description: Create a C# console application that computes the first 25 numbers of the Fibonacci sequence.

using System;

namespace Deliverable_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 1;
            int n3;

            Console.WriteLine("Fibonacci number (0) = 0");
            Console.WriteLine("Fibonacci number (1) = 1");

            for (int i = 2; i < 25; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine("Fibonacci number ({0}) = {1}", i, n3);
                n1 = n2;
                n2 = n3;
            }

            Console.ReadLine();
        }
    }
}