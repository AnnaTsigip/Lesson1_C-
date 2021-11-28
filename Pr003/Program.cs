// // По заданному номеру дня недели вывести его название

int dayOfWeek = 2;
if (dayOfWeek == 1)
{
    Console.WriteLine("Понедельник");

} 
else if (dayOfWeek == 2)
{
    Console.WriteLine("Вторник");
}

else if (dayOfWeek == 3)
{
    Console.WriteLine("Среда");
}
else if (dayOfWeek == 4)
{
    Console.WriteLine("Четверг");
}
else if (dayOfWeek == 5)
{
    Console.WriteLine("Пятница");
}
else if (dayOfWeek == 6)
{
    Console.WriteLine("Суббота");
}
else if (dayOfWeek == 7)
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Мы не знаем такого значения");
}

string[] dayOfWeek = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
if((dayOfWeek) > 0 && (dayOfWeek) <= dayOfWeek.Lengh)
{
    Console.WriteLine(dayOfWeek[dayOfWeek - 1]);
}
else
{
    Console.WriteLine("Мф не знаем такого значения");
}