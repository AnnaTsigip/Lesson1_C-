// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
// будни 1-5, выходной 6-7
// ввести число, проверить соответствие

Console.WriteLine("Введите число от 1 до 7"); 
int dayOfWeek = int.Parse(Console.ReadLine());
Console.WriteLine();
if (dayOfWeek < 6)
{
    Console.WriteLine("Будний день, не выходной");
}
else
{
    Console.WriteLine("Выходной");
}
