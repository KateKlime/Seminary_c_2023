//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите число ");
int Num = Convert.ToInt32(Console.ReadLine());
int digitFirst = Num / 100;
int digitThird = Num % 10;
int digitSecond = (Num - digitFirst * 100 - digitThird) / 10;
Console.WriteLine(digitSecond);
