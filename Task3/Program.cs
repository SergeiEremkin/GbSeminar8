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
int[] ArrayFromTwoToMono(int[,] array)
{
    int[] arr = new int[array.Length];
    int index = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arr[index] = array[i, j];
            index++;
        }
    }
    return arr;

}

int[] SortArray(int[] array)
{
    int Max = array[0];
    int Temp = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                Temp = array[i];
                array[i] = array[j];
                array[j] = Temp;
            }
        }
    }
    return array;
}
void CounterOfSameArrayNumbers(int[] array)
{
    int counter = 1;
    for (int i = 0; i < array.Length-1; i++)
    {
        if (array[i] == array[i + 1])
        {
            counter++;
        }
        else
        {
            Console.WriteLine($"{array[i]} встречается  {counter} раза");
            counter = 1;
        }
    }
        Console.WriteLine($"{array[array.Length-1]} встречается  {counter} раза");

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

void PrintMonoArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}
int[,] arr = CreateArray(3, 4);
FillArray(arr);
PrintArray(arr);
int[] MonoArray = ArrayFromTwoToMono(arr);
PrintMonoArray(MonoArray);
SortArray(MonoArray);
System.Console.WriteLine();
PrintMonoArray(MonoArray);
System.Console.WriteLine();
CounterOfSameArrayNumbers(MonoArray);

