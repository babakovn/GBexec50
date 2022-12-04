int[,] GetRandomArray(int rows, int column)
{
    int[,] arr = new int[rows, column];
    Random a = new Random();
    for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < column; j++)
            {
                arr[i,j] = a.Next();
            }
        }
    return arr;
}

void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i,j]} ");
            }
        Console.WriteLine();
        }
}



//

int[,] arr = GetRandomArray(3,4);
PrintArray(arr);