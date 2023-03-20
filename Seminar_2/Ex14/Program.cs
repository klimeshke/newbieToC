// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "");

// bool result = (num % 7 == 0 && num % 23 == 0); ---- bool сохраняет true false
// if (result)                                ___/
// {

if (num % 7 == 0 && num % 23 == 0)
    Console.WriteLine($"Число {num} кратно 7 и 23");
else
    Console.WriteLine($"Число {num} НЕ кратно");