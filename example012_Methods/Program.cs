//  Виды методов
// Вид 1 - ничего не принимает ничего не возвращает

void Method1 ()
{
    Console.WriteLine("Автор...");
}
Method1();

// Вид 2 принимает аргументы, но ничего не возвращает
void Method2 (string txt)
{
    Console.WriteLine(txt);
}
Method2("Текст сообщения");

// использование именованных аргументов
void Method2_1 (string txt, int count)
{
    int i = 0;
    while (i < count)
    { 
        Console.WriteLine(txt);
        i++;
    }
}
Method2_1("Текст второго сообщения", 2);
Method2_1(count: 3, txt: "Текст третьего сообщения"); // именованый аргумент может идти в любом порядке

//  Вид 3 - не примает, но возвращает
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Вид 4 - и принимает и возвращает
string Method4 (int counter, string message)
{
    int i = 0;
    string result = String.Empty;
    while (i < counter)
    {
        result = result + message;
        i++;
    }
    return result;
}
string res = Method4(4, "ab1");
Console.Write (res);
