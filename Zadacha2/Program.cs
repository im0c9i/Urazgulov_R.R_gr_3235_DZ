﻿/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

using System;
using System.Globalization;
 
namespace ZAD1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] i = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(i[0]);
            int b = Convert.ToInt32(i[1]);
            int c = Convert.ToInt32(i[2]);
            Console.WriteLine(Math.Max(a, Math.Max(b, c)));
 
 
 
        }
    }
}

