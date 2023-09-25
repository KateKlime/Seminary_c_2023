// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int N = new Random().Next(100,1000);
Console.WriteLine($"случайное число: {N}");
int digitFirst = N/100;
int digitThird = N%10;
Console.Write(digitFirst);
Console.Write(digitThird);
