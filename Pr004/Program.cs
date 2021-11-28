// Найти максимальное из трех чисел
int a = 1;
int b = 5;
int c = 3;

int max = a;

if (a < b)
{
    max = b;
}
else
{
    max = a;
}

if (max < c)
{
    max = c;
}

Console.WriteLine(max);
