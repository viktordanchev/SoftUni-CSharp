﻿using System;

namespace _04.Sequence2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int counter = 1;

            while (counter <= num)
            {
                Console.WriteLine(counter);
                counter = counter * 2 + 1;
            }
        }
    }
}
