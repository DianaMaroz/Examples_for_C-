// выведение индекса нужного элемента в массиве
int[] array ={11, 2, 13, 56, 15, 56, 71, 28, 39};
int n = array.Length; // длина массива
int find = 56;
int index = 0; //  если элемент не будет найдет, то будет выведена -1
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // оператор break перывает выполнение функции и выведет только первый индекс, а не все
    }
    index++;
}
