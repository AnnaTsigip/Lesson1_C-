// Показать четные числа от 1 до N
// определяем N
// счетчик +1
// четное число определяем еленем с остатком на 2

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine();

int count = 1;

while (count <= N)
{
    if (count % 2 == 0)
    {
        Console.WriteLine(count);
    }
    count++;
}

