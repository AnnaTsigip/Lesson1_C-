// Найти кубы чисел от 1 до N
// ввести N
// число возвести в куб - a*a*a


 Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int count = 1; count <= N; count++)
{
   int cubeNumber = count * count * count;
   Console.WriteLine($"число {count} в кубе = {cubeNumber}");
}


