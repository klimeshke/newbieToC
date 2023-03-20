// Напишите программу, которая будет принимать на вход два числа и выводить, является ли одно число квадратом другого
Console.Clear();

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine() ?? "");

bool result = (num1 == num2 * num2 || num2 == num1 * num1);

if (result)
    Console.WriteLine($"{num1}, {num2} -> ДА");
else
    Console.WriteLine($"{num1}, {num2} -> НЕТ");