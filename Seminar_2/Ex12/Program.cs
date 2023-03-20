// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому
// Если второе число не кратно превому числу, то программа выводит остаток от деления.
Console.Clear();

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine() ?? "");

if (num1 % num2 == 0)
    Console.WriteLine($"Кратно");
else
{
    int rem = num1 % num2;
    Console.WriteLine($"Не кратно. Остаток от деления -> {rem}");
}