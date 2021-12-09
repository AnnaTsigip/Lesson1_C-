// Написать программу вычисления произведения чисел от 1 до N
// вводим N
// пока i <= N умножаем числа



Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int multiplication = 1;

    for (int i = 1; i <= N; i++)
    {
        multiplication = multiplication * i;
        
    }

Console.WriteLine($"Произведение чисел от 1 до {N} = {multiplication}");
