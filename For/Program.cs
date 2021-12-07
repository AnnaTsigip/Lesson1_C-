// 
// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;

//     }
//     return result;
// }
// string res = Method4(10, "Привет!");
// Console.WriteLine(res);


// таблица умножения

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}");
//     }
//     Console.WriteLine();

// }

// замена букв
// string text = "- Я думаю, - сказал князь, улыбыясь, -что,"
//             + "ежели бы вас послали вместо нашего милого Винцегороде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty; // вывод пустой строки
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }

// String newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'о', 'О');
// Console.WriteLine(newText);
// newText = Replace(newText, 'с', 'С');
// Console.WriteLine(newText);


//Сортировка массива

 int[] arr = { 1, 5, 3, 2, 1, 7, 6, 5 }; // заводим массив
 
 //метод для выведения массива на экран, метод void

 void PrintArray(int[] array)
 {
     int count = array.Length;
     for (int i = 0; i < count; i++)
     {
         Console.Write($"{array[i]} ");
     }
     Console.WriteLine();
         
 }

// Метод для упорядочивания массива

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++) // пробегаемся по всем элементам нашего массива
    {
        int minPosition = i;

        // находим следующий элемент
        for (int j = i + 1; j < array.Length; j++)    
        {
        if(array[j] < array[minPosition]) minPosition = j;   //минимальный элемент
        }

//перемещение элемента через temp(простой обмен двух переменных местами)
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
    
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

