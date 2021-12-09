// Определить количество цифр в числе
// ввести число
// делить число на %10, посчитать сколько делений потребовалось?

// int num = new Random().Next();
// Console.WriteLine("Рандомное число: ");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit = 0;
int num = 0;
//Console.WriteLine(num);
while (number > 0)
{
    num = number / 10;
    //number = count;
    digit++;

}
Console.WriteLine(2);
Console.WriteLine($"Данное число содержит {digit} цифр");
