// Программа проверяет пятизначное число на палиндромом.
// вводим 5-значное число
//палиндром 1=5, 2=4 цифрам числа

Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
int temp = number;
int invertedNumber = 0;

if (temp > 99999 || temp < 10000)
{
    Console.WriteLine("Число не пятизначное");
}
else
{

    while (temp != 0)
    {
        invertedNumber = invertedNumber * 10 + temp % 10;
        temp = temp / 10;
    }

    if (number == invertedNumber)
    {
        Console.WriteLine("Число - палиндром");
    }
    else
    {
        Console.WriteLine("Число не палиндром");
    }
}




