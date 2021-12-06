// Функции
// тип_данных_возвращаемый имя_метода(входной параметр1, входной параметр2, ..., входной параметрN)
// {
// из_набора_опреаторов_и_синтаксических_конструкций;    
// }
//метод Void - ничего не возвращает
void myMethod()
{
    int a = 0;
    int b = 5;
    Console.WriteLine(a + b);
}

myMethod();

//return  - возвращаемый метод


int myMethod1()
{
    int a = 1;
    int b = 5;
    return a + b;
}

int c = myMethod1();
Console.WriteLine(c);


bool myMethod2()
{
    int a = 8;
    int b = 7;
    return a < b;
}

bool flag = myMethod2();
Console.WriteLine(flag);


//Входной параметр - тип_данных имя_переменной

int myMethod3(int a, int b)
{
    return a + b; 
}

int k = myMethod3(2, 5);

int x = 5;
int y = 10;

int z = myMethod3(x, y);
Console.WriteLine(z);
Console.WriteLine(k);


