Console.Clear();
// РЕШЕНИЕ 1
// Console.Write("Введите целое число: ");                      --\
// string userInputStr = Console.ReadLine();                    ------ ВВОД ДАННЫХ
// int userNumber = int.Parse(userInputStr);                    --/

// int result = userNumber * userNumber;                        ------ РЕШЕНИЕ

// Console.WriteLine($"Квадрат {userNumber} равен {result}");   ------ РЕЗУЛЬТАТ

////////////////////////////////////////////////////////

// РЕШЕНИЕ 2
// Console.Write("Введите целое число: ");
// int userNumber = int.Parse(Console.ReadLine());

// int result = userNumber * userNumber;

// Console.WriteLine($"Квадрат {userNumber} равен {result}");

Console.Write("Введите целое число: ");
int userNumber = int.Parse(Console.ReadLine() ?? "");

int result = (int)Math.Pow(userNumber, 2); //явное преобразование в интеджер

Console.WriteLine($"Квадрат {userNumber} равен {result}");