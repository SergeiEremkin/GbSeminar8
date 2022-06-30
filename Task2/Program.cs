int[,] CreateArray(int n, int m)
{
    return new int[n, m];
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
int[,] ChangeRowsAndCols(int[,] array)
{
    int[,] SwitchedArray = new int[array.GetLength(0), array.GetLength(1)];

    if (array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < SwitchedArray.GetLength(1); j++)
            {
                SwitchedArray[j, i] = array[i, j];
            }
        }
    }
    else
    {
        System.Console.WriteLine("Невозможно поменять элементы. Кол-во строк и столбцов не равно");
    }
    return SwitchedArray;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        System.Console.WriteLine();
    }
}
int[,] arr = CreateArray(4, 4);
FillArray(arr);
PrintArray(arr);
int[,] newArray = ChangeRowsAndCols(arr);
System.Console.WriteLine();
PrintArray(newArray);


