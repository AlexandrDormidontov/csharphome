﻿//Задача 10: Напишите программу,
// которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("start");

Console.WriteLine("Введите трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
a = ((a / 10) % 10);
Console.WriteLine(a);

Console.WriteLine("end");

    