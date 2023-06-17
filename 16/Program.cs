// 14 Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8, 9 -> нет

Console.Clear();
Console.WriteLine("Введите два числа");
Console.Write("Первое число ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Второе число ");
int num2 = int.Parse(Console.ReadLine());
if (num1 == num2 * num2) // для простого ответа можно написать оба условия вместе через или ||
    Console.WriteLine($"Число {num1} является квадратом числа {num2}");
else if (num2 == num1 * num1)
    Console.WriteLine($"Число {num2} является квадратом числа {num1}");
else 
    Console.WriteLine($"Ни одно число не является квадратом другого");