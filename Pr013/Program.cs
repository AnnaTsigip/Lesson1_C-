// Выяснить, кратно ли число заданному, если нет, вывести остаток.
// вводим 2 числа
// 1/2 = остаток 0, кратные
// 1/2 с остатком - некратные

Console.WriteLine("Введите число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Кратно: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 % number2 == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    int number3 = number1 % number2;
    Console.WriteLine("Осстаток от деления числа1 на число2");
    Console.WriteLine(number3);
}
