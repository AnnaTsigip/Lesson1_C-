// Подсчитать сумму цифр в числе
// вводим число int
// разложить число на цифры
// складываем цифры числа

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int summa = 0;
int i = 0;
while (N > 0)
{

    summa = summa + N % 10;
    N = N / 10;
    i++;
}

Console.WriteLine($"сумма цифр числа N = {summa}");// как обозначить N чтобы была первоначальная цифра, а не 0




















