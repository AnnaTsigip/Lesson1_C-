// Показать таблицу квадратов чисел от 1 до N
// ввести N
// квадрат числа ^2, или число умноженное на само себя

// int squareNumber(int n, int N)
// {
//     for (int count = 1; count <= N; count++)
//     {
//        n = 1;
//        N = 10;
//        return n * n;

//     }
// }

// int square = squareNumber;
// // Console.WriteLine("Введите число N: ");
// // int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"квадрат числа n равен {square}");

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int count = 1; count <= N; count++)
{
   int squareNumber = count * count;
   Console.WriteLine($"квадрат числа {count} равен {squareNumber}");
}

