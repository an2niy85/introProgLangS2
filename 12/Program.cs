// 12 Напишите программу, которая будет принимать на вход два числа и вывдить,
// является ли второе число кратныи первому. Если второе число не кратно первому,
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Clear();
Console.WriteLine("Введите два числа");
Console.Write("Первое число ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Второе число ");
int num2 = int.Parse(Console.ReadLine());
if (num1 % num2 == 0)
    Console.WriteLine($"Число {num2} кратно числу {num1}");
else Console.WriteLine($"Число {num2} не кратно числу {num1}, остаток {num1 % num2}");