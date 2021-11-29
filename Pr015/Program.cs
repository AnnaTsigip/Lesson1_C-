// Дано число. Проверить кратно ли оно 7 и 23
// число кратно числу, если делится без остатка, т.е. если число % на 7 и 23 = 0
// вводим число, делим на 7 и 23 % на 7 и 23 = 0, кратно, если % 7 и 23 > 0, некратно

Console.WriteLine("Введите число для проверки: ");
int numberToChek = int.Parse(Console.ReadLine());
Console.WriteLine();

if(numberToChek % 7 == 0)
{
    Console.WriteLine("Число кратно 7");
}
else
{
    Console.WriteLine("Число не кратно 7");
}

if (numberToChek % 23 == 0)
{
    Console.WriteLine("Число кратно 23");
}
else
{
    Console.WriteLine("Число не кратно 23");
}
