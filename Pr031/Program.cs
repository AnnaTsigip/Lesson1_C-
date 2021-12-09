// Задать массив из 8 элементов и вывести их на экран

int[] myarray = new int[8];
myarray[0] = 1;
int i = 0;
while (i < myarray.Length)
{
    myarray[i] = i + 1;
    i++;
}

void PrintArray (int[] array)
{
   int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
PrintArray(myarray);
