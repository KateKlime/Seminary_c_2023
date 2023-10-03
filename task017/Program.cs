//Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
//причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

void DetectedQuaters (int x, int y)
{
if(x>0 && y>0) 
{
    Console.WriteLine("точка находится в первой четверти");
}
else
    if(x>0 && y<0)
{
    Console.WriteLine("точка находится в четвёртой четверти");
}   
else
    if(x<0 && y<0)
{
    Console.WriteLine("точка находится в третьей четверти");
}   
else
    if(x<0 && y>0)
{
    Console.WriteLine("точка находится во второй четверти");
}  
else
{
    Console.WriteLine("точка не может содержать ноль");
}  
}

Console.WriteLine("Введите координату Х  ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y  ");
int y = Convert.ToInt32(Console.ReadLine());
DetectedQuaters(x, y);