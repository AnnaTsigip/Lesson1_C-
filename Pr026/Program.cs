// Возведите число А в натуральную степень B используя цикл
// ввести А
// ввести степень
// Умножение А на А по числу B

Console.WriteLine("Ведите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральную степень B: ");
int B = Convert.ToInt32(Console.ReadLine());
int degreeA = 1;
for (double i = 1; i <= B; i++)
{
    
  degreeA *= A;

}
//degreeA = Math.Pow(A, B); тогда double
Console.WriteLine($"Число {A} в степени {B} = {degreeA}");

