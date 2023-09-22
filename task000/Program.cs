// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное
// на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49
Console.WriteLine("Введите число:  ");
int number = Convert.ToInt32(Console.ReadLine());//перевод строки в число
int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");// $ - можем ссылаться на переменные