// Удалить вторую цифру трёхзначного числа
// ввести число
//найти первую
//  найти третью
//  вывести из на экран


Console.WriteLine("Введите трехзначное число: ");
int threeDigitNumber = int.Parse(Console.ReadLine());
Console.WriteLine();

if (threeDigitNumber >= 100 && threeDigitNumber <= 999)
{
    int firstDigitNumber = threeDigitNumber % 100;
    int thirDigitaldNumber = threeDigitNumber % 10;
    int secondDigitNumber = firstDigitNumber + thirDigitaldNumber;
    Console.WriteLine("Без второй цифры:");
    Console.WriteLine(secondDigitNumber);
}
else
{
    Console.WriteLine("Неверное количество символов в числе");
}



