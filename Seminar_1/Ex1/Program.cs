Console.Clear();

Console.Write("Введите превое число: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numB = int.Parse(Console.ReadLine());

int check = (int)Math.Pow(numB, 2);

if (check == numA)
    Console.WriteLine("ДА");
else
    Console.WriteLine("НЕТ");

Console.WriteLine($"{numA} {numB}");
