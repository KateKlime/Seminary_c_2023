//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());
if (Num < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    while(Num > 999) Num = Num / 10;
    int thirdnum = Num % 10;
    Console.WriteLine(thirdnum);
}