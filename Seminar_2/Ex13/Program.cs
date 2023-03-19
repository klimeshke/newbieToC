// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();

Console.Write("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine() ?? "");

int check3 = (num / 100);
int a3 = ((num % 100) % 10);

if (check3 == 0)
    Console.WriteLine("Третьей цифры нет");
else Console.WriteLine($"Третья цифра в числе {num} -> {a3}");
