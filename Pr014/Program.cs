// Найти третью цифру числа или сообщить, что её нет
// ввести число
// третья цифра определяется делением %100

Console.WriteLine("Введите число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine();

if (number1 < 100)
{
    Console.WriteLine("Третьей цифры нет");
}

if (number1 >= 100 && number1 <= 999)
{
 int thirdDigit = number1 / 100;
 Console.WriteLine("Третье число: ");
 Console.WriteLine(thirdDigit);
}

if (number1 > 999)
{
    int cutNumber = number1 % 1000;
    int thirdDigit = cutNumber / 100;
    Console.WriteLine("Третье число: ");
    Console.WriteLine(thirdDigit);
}
