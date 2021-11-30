// По двум заданным числам проверять является ли одно квадратом другого
// ввести 2 числа int
//если 1*1=2, значит первое является квадратом второго

Console.WriteLine("Введите первое число: ");
int firstDigit = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondDigit = int.Parse(Console.ReadLine());

if (firstDigit * firstDigit == secondDigit)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}
if (secondDigit * secondDigit == firstDigit)
{
    Console.WriteLine("Второе число является квадратом первого");
}
else
{
    Console.WriteLine("Второе число не является квадратом первого");
}
