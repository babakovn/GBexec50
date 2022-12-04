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

bool CheckNumArr(int num, int[,] arr)
{
    bool check = false;
    for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                if(arr[i,j] == num) check = true;
            }
        
        }
    return check;    
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
        Console.WriteLine("Введено неверное число, таких строк нет в массиве.");
    }

int y = 0;
while(true)
    {
        Console.Write($"Введите столбец числа в массиве:");
        if(int.TryParse(Console.ReadLine(), out y))
            if(y <= arr.GetLength(1) && y > 0) break;
        Console.WriteLine("Введено неверное число, таких столбцов нет в массиве.");
    }




Console.WriteLine($"Элемент массива [{x}, {y}] равен {arr[x-1,y-1]}");

int num = 0;
while(true)
    {
        Console.Write($"Введите число для проверки в массиве:");
        if(int.TryParse(Console.ReadLine(), out num)) break;
        Console.WriteLine("ошибка ввода!");
    }

if(CheckNumArr(num, arr)) 
    Console.WriteLine($"Число {num} есть в массиве");
else
    Console.WriteLine($"Числа {num} нет в массиве");

