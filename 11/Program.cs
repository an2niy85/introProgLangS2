// 11 Напишите программу, которая выводит
// случайное трехзначнное число и удаляет
// вторую цифру этого числа.
Console.Clear();
int num = new Random().Next(100, 1000);
int num1 = num / 100;
int num2 = num % 10;
int num3 = num1*10 + num2;
System.Console.WriteLine($"Число из крайних цифр числа {num} -> {num3}");