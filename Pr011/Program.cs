﻿// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int num = new Random().Next(10, 99);
Console.WriteLine("Рандомное число: ");
Console.WriteLine(num);
int digital1 = num % 10;
int digital2 = num / 10;

if (digital1 > digital2)
{
    Console.WriteLine("Наибольшая цифра ");
    Console.WriteLine(digital1);
}
else
{
    Console.WriteLine("Наибольшая цифра ");
    Console.WriteLine(digital2);
}
