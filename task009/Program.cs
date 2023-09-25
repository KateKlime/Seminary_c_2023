// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.
int number = new Random().Next(10, 100); //[10,100)
Console.WriteLine($"случайное число: {number}");
int digitFirst = number/10; // 45%10=5, а когда мы делаем 45/10=4.5=4(и 5 остается в остатке)
int digitSecond = number%10;
if(digitFirst > digitSecond)
{
    Console.WriteLine(digitFirst);
}
else
   { 
    if(digitSecond > digitFirst)
{
    Console.WriteLine(digitSecond);
}
    else
    {
        Console.WriteLine("цифры равны");
    }
   }