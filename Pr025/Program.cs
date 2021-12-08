// Найти сумму чисел от 1 до А
// вводим число А
// переменную сумма, ддобавляем в сумму все числа от 1 до А

Console.WriteLine("введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
int summa = 0;
for (int count = 1; count <= A; count++)
{
    summa = summa + count;
    
}
Console.WriteLine($"сумма всех числел от 1 до {A} = {summa}");