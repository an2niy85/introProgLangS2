﻿// 14 Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.

// if ((a > b || a < c) && (x > b || x < c) || d == 5) <=> 0 && 1 || d == 5
//        0   +    0          1   +    0
//            0         *         1
//                      0                   +    1
//                                          1

Console.Clear();
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
if (num % 7 == 0 && num % 23 == 0)
    Console.WriteLine($"Число {num} кратно одновременно числам 7 и 23");
else Console.WriteLine($"Число {num} не кратно  одновременно числам 7 и 23");