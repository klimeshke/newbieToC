// Напишите программу, которая выводит случайное число из отрезка [100, 999] и показывает наибольшую цифру числа.
Console.Clear();

int num = new Random().Next(100, 1000);
int a1 = num / 100;
int a2 = ((num / 10) % 10);
int a3 = ((num % 100) % 10);
int max = a1;
if (max < a2)
    max = a2;
if (max < a3)
    max = a3;

Console.WriteLine($"Максимальная цифра в числе {num} -> {max}");
