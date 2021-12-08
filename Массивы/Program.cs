// массивы(одномерные)
// тип_данных[] имя_переменной = {значение_1, значение_2, ..... значение_N };
// тип_данных[] имя_переменной = new тип_данных[длина];

//int[] myArray = new int[5]; // [0] [0] [0] [0] [0] - по умолчанию заполняется 0, bool - fals
//myArray[0] = 1; // [1] [0] [0] [0] [0]

//свойства массива

//Console.WriteLine(myArray.Length);


int[] myArray = new int[70];
myArray[0] = 1;

int i = 0;
while(i < myArray.Length)
{
    //заполнение последовательности от 1 до 50
    myArray[i] = i + 1;
    i++;

}

//i = 0;
//while(i < myArray.Length)
//{
//заполнение последовательности от 1 до 50
//Console.Write(myArray[i] + " "); 
//i++;

//}
void showArray(int[] array)
{
    for (int y = 0; y < myArray.Length; y++)
    {
        Console.Write(myArray[y] + " ");
    }
}

void changeArray(int[] arr)
{
    for (int y = 0; y < arr.Length; y++)
    {
        arr[y] = 1;
    }
}


//изменение массива array значением из arr, т.к. массив ссылочное значение
showArray(myArray);
changeArray(myArray); 
Console.WriteLine();
showArray(myArray);


