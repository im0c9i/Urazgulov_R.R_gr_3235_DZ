﻿/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.WriteLine("Введите число: ");

int nambers = int.Parse(Console.ReadLine());
for (int i = 2 ; i <= nambers; i = i + 2)
{
    if (i % 2 ==0)
    {
    Console.WriteLine($" {i} ");
    }
}