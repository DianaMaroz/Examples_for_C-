// Двумерные массивы
string[,] table = new string[2,3];  // по умолчаниб заполняется пустыми строками String.Empty
table[0,0] = "Заголовок";
table[0,1] = "Столбец1";
table[0,2] = "Столбец2";
table[1,0] = "Значение";
table[1,1] = "Значение1";
table[1,2] = "Значение2";
// PrintTwoDimensionsStrArray(table);
void PrintTwoDimensionsStrArray (string[,] tabl)
{
    for (int i = 0; i < tabl.GetLength(0); i++) // GetLenght(0) - строки
    {
        for (int j = 0; j < tabl.GetLength(1); j++) // GetLenght(1) - столбцы
        {
            Console.Write($"| {tabl[i,j]} |");
        }
        Console.WriteLine();
        Console.WriteLine("__________________________________________________________");
    }
}
void PrintTwoDimensionsIntArray (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // GetLenght(0) - строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // GetLenght(1) - столбцы
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}
void FillIntArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++) // GetLenght(0) - строки
    {
        for (int j = 0; j < array.GetLength(1); j++) // GetLenght(1) - столбцы
        {
            array[i,j] = rnd.Next(1,10);
        }
    }
}
int[,] intArray = new int[3,4];
FillIntArray(intArray);
PrintTwoDimensionsIntArray(intArray);
int[,] pic = new int[,]
{
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
    {0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0},
    {0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0},
    {0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0},
    {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
    {0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
    {0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
};
PrintImage(pic);
FillImage(3,3);
PrintImage(pic);
void PrintImage (int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i,j]== 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
}
void FillImage(int row, int col)
{
    if (pic[row, col] == 0)
    {
        pic[row,col] = 1;
        FillImage (row-1, col);
        FillImage (row, col-1);
        FillImage (row+1, col);
        FillImage (row, col+1);
    }
}

