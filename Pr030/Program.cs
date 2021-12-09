// Показать кубы чисел, заканчивающихся на четную цифру
// вводим числа для определнеия куба
// вычисляем кубы чисел
// если %2 == 0 - четное выводим в Console

Console.WriteLine("Введите число до которого считаем: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    int cubeNumber = i * i * i; 
   // Console.WriteLine($"число {i} в кубе = {cubeNumber}");

    if (cubeNumber % 2 == 0)
    {
       Console.WriteLine($"число {i} в кубе = {cubeNumber} четное"); 
    }
}


// int Method(int N)
// {
// for (int i = 1; i <= N; i++)
// {
// return i * i * i;
// }

// }

// Console.WriteLine("Введите N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int cube = Method(N);


    
//     //


// if (cubeNumber % 2 == 0) ;

// Console.WriteLine($"число {i} в кубе = {cubeNumber} четное");
//Console.WriteLine($"число {i} в кубе = {cubeNumber}");



