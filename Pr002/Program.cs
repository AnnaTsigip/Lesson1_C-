// Даны два числа. Показать большее и меньшее число

// вводим 2 числа int

int thirdTaskFirstValue = 9;
int thirdTaskSecondValue = 10;

if (thirdTaskFirstValue > thirdTaskSecondValue)
{
    Console.WriteLine("Большее " + thirdTaskFirstValue);
    Console.WriteLine("Меньшее " + thirdTaskSecondValue);
}
 else if (thirdTaskFirstValue < thirdTaskSecondValue)
 {
    Console.WriteLine("Большее " + thirdTaskSecondValue);
    Console.WriteLine("Меньшее " + thirdTaskFirstValue);  
 }
else
{
    Console.WriteLine("Числа равны!");
}
