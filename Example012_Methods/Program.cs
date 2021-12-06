// вид 1 void ничего не возвращает
// void Method1()
// {
//     Console.WriteLine("Афтор ...");
// }

// Method1(); //Вызвать метод


// Вид 2 ничего не возвращает, но может принимать значения
 
//  void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
  int i = 0;
  while (i < count)
  {
      Console.WriteLine(msg);
      i++;
  }  
}
//Method21(msg: "Текст", count: 4);
Method21(count: 4, msg: "новый текст");


// вид3 что возвращает, но не принимает

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

//вид4 что-то принимают и что-то возвращают

string Method4(int count, string текс)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + текс;
        i++;
    }
return result;
}
string res = Method4(10, "Привет!");
Console.WriteLine(res);


