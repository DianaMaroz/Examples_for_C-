//заполнение массива случайными числами
void FillArray(int[] collection) // void - функция без return , в качестве аргумента массив
{
    int lenght = collection.Length;
    int index = 0;
    while(index < lenght)
    {
        collection[index] = new Random().Next(0, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int pos = 0;
    while(pos < count){
        Console.WriteLine(col[pos]);
        pos++;
    }
}
// функция поиска заданного элемента в массиве
int IndexOf (int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int indexOf = -1; // если элемент отсутвует в списке вернет -1
    while (index < count) 
    {
        if (collection[index] == find) 
        {
            indexOf = index;
            break;
        }
        index++;
    }
    return indexOf;
}


int[] array = new int[10]; // создание массива с десятью ячейками, по умолчанию заполнено нулями
FillArray(array);
PrintArray(array);
Console.WriteLine();
int indexOf = IndexOf(array, 4);
Console.WriteLine(indexOf);

