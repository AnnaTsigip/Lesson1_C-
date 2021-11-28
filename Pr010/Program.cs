// Показать вторую цифру трёхзначного числа
// 1. Введем трехзначное число
// 2. Проверим его
// 3. найдем 1 цифру % 100
// 4. выведем 2 цифру  остаток от п.3 / 10
//

Console.WriteLine("Введите трехзначное число: ");
int threeDigitNumber = int.Parse(Console.ReadLine());
Console.WriteLine();

if (threeDigitNumber >= 100 && threeDigitNumber <= 999)
{
 int firstNumder = threeDigitNumber % 100;
 int seconddNumber = firstNumder / 10;
 Console.WriteLine(seconddNumber);
}

else 
Console.WriteLine("Неправильное число символов");