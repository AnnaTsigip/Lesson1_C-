// Задать номер четверти, показать диапазоны для возможных координат
//Вести номер четверти
//1 четверть -  х и у > 0 , т.е. от 0 до +
// 2 четверть х<0, y>0 Х от 0 до -, У от 0 до +
// 3 четверть x и y < 0, т.е. от 0 до -
//4 четверть x>0, y<0 , т.е Х от 0 до +, У от 0 до -


int quarterNumber = new Random().Next(1, 4);
Console.WriteLine("Номер четверти: ");
Console.WriteLine(quarterNumber);

if (quarterNumber == 1)
{
    Console.WriteLine("X и Y от 0 до + бесконечности");
}
if (quarterNumber == 2)
{
    Console.WriteLine("X от 0 до - бесконечности, Y от 0 до + бесконечности");
}
if (quarterNumber == 3)
{
    Console.WriteLine("X и Y от 0 до - бесконечности");
}
if (quarterNumber == 4)
{
    Console.WriteLine("X от 0 до + бесконечность, Y от 0 до - бесконечности");
}

