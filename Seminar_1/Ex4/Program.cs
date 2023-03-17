// Напишите программу, которая принимает на вход  три числа и выдаёт максимальное из этих чисел

Console.Clear();

Console.Write("Введите первое число: ");
int numA = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите второе число: ");
int numB = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите третье число: ");
int numC = int.Parse(Console.ReadLine() ?? "");

if (numA > numB && numA > numC)
    Console.WriteLine($"{numA} большее из чисел");
else if (numB > numC && numB > numA)
    Console.WriteLine($"{numB} большее из чисел");
else if (numC > numB && numC > numA)
    Console.WriteLine($"{numC} большее из чисел");