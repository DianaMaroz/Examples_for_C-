// Цикл for включает инициатор условие выхода, инпермент (т.е. увеличение инициатора)
 string Method4 (int counter, string message)
{
    string result = String.Empty;
    for (int i = 0; i < counter; i++)
    {
        result = result + message;
    }
    return result;
}
// string res = Method4(4, "ab1");
// Console.Write (res);

//цикл в цикле - таблица умножения
void MultiplicationTable()
{
    for (int i = 2; i <= 10; i++)
    {
        for (int j =2; j <= 10; j++)
        {
            Console.WriteLine($"{i} x {j} = {i * j}");
        }
        Console.WriteLine();
    }
    
}
// MultiplicationTable();

//Работа со строками
string text = " Толькi ў сэрцы трывожным пачую "
+ "За краiну радзiмую жах - "
+ "Ўспомню Вострую Браму сьвятую "
+ "I ваякаў на грозных канях.";

string Replase (string txt, char oldValue, char newValue)
{
    string result = String.Empty;
    int lenght = txt.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (txt[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{txt[i]}";
    }
    return result;
}
// string res = Replase(text, 'в', 'В');
// Console.WriteLine(res);
// string newText = Replase(text, 'с', 'С');
// Console.WriteLine(newText);

// сортировка методом выбора
int[] array1 = {1, 4, 3, 8, 2, 1, 1, 8};
int[] array2 = {1, 4, 3, 8, 2, 1, 1, 8};
void PrintArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} " );
    }
}

void SelectSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i +1 ; j <  arr.Length; j++)
        {
            if (arr[j] < arr[minPosition]) minPosition = j;
        }
        int temporary = arr[i];
        arr[i] = arr[minPosition];
        arr[minPosition] = temporary;
    }
}

void SelectSortMax(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i +1 ; j <  arr.Length; j++)
        {
            if (arr[j] > arr[maxPosition]) maxPosition = j;
        }
        int temporary = arr[i];
        arr[i] = arr[maxPosition];
        arr[maxPosition] = temporary;
    }
}
PrintArray(array1);
Console.WriteLine();
SelectSort(array1);
PrintArray(array1);
Console.WriteLine();
SelectSortMax(array2);
PrintArray(array2);