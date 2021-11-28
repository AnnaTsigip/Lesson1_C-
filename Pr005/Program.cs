// Написать программу вычисления значения функции y = f(a)
// y = x -1, x>=0
// y= |x|, x < 0

int x = -1;

if (x >= 0)
{
    Console.WriteLine(x - 1);
}
else 
{
    Console.WriteLine(Math.Abs(x));
}
