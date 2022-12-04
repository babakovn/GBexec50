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

int[,] arr = GetRandomArray(4,5);
PrintArray(arr);

int x = 0; 
while(true)
    {
        Console.Write($"Введите строку числа в массиве:");
        if(int.TryParse(Console.ReadLine(), out x))
            if(x <= arr.GetLength(0) && x > 0) break;
        Console.WriteLine("Ошибка ввода");
    }

int y = 0;
while(true)
    {
        Console.Write($"Введите столбец числа в массиве:");
        if(int.TryParse(Console.ReadLine(), out y))
            if(y <= arr.GetLength(1) && y > 0) break;
        Console.WriteLine("Ошибка ввода");
    }




Console.WriteLine($"{arr[x-1,y-1]}");


