// Подсчитать сумму цифр в числе
// вводим число int
// разложить число на цифры
// складываем цифры числа

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int temp = 0;
int i = 0;
while (N > 0)
{

    temp = temp + N % 10;
    N = N / 10;
    i++;
}

Console.WriteLine(temp);




















