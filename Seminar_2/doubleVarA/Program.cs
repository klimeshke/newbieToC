// Циклический ввод переменной типа double

double varA;

while (true)
{
    Console.Write("Введите А: ");
    if (double.TryParse(Console.ReadLine(), out varA)) // TryParse - попыткапарсить, out - вывод наружу в переменную
        break;
    Console.WriteLine("Ошибка ввода!");
}
Console.WriteLine($"A = {varA}");
