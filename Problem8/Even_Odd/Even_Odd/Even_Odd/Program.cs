﻿using System;

namespace Even_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a number to check : ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
                Console.WriteLine(n + " is an even number");
            else
                Console.WriteLine(n + " is an odd number");
        }
    }
}