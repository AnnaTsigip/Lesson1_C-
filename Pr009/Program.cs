// Показать последнюю цифру трёхзначного числа
// 1. Ввести число
// 2. проверить сколько в нем цифр
// 3. найти третью цифру делением на 10 с статком

Console.WriteLine("Введите трехзначное число: ");
int threeDigitNumber = int.Parse(Console.ReadLine());
Console.WriteLine();

if (threeDigitNumber >= 100 && threeDigitNumber <= 999)
{
    int thirdNumber = threeDigitNumber % 10;
    Console.WriteLine(thirdNumber);
}

else 
Console.WriteLine("Неправильное число символов");

