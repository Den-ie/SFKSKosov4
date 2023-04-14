2 Задание - 5 практос

```csharp
    static string ReetCultString(string inputString)
    {
        char[] symbolsArray = inputString.ToCharArray();

        for (int i = 2; i < symbolsArray.Length; i += 3)
        {
            if (Char.IsLetter(symbolsArray[i]))
            {
                symbolsArray[i] = Char.ToUpper(symbolsArray[i]);
            }
        }

        string resultString = new string(symbolsArray);

        return resultString;
    }
```

Вот решение задачи на C#:

```csharp
    static void Main(string[] args)
    {
        Console.Write("Введите размерность массива: ");
        int n = Int32.Parse(Console.ReadLine());

        int[,] array = new int[n, n];

        Console.WriteLine("Введите элементы массива:");

        // заполнение массива
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = Int32.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        int[] spiralArray = ReetCult(array);

        Console.WriteLine("Отсортированный массив по внутренней спирали:");
        PrintArray(spiralArray);

        Console.ReadLine();
    }

    static int[] ReetCult(int[,] array)
    {
        int n = array.GetLength(0);
        int m = array.GetLength(1);

        int[] spiralArray = new int[n * m];

        int index = 0;

        int i = 0, j = 0;
        int left = 0, top = 0, right = m - 1, bottom = n - 1;
        int direction = 0;

        while (left <= right && top <= bottom)
        {
            if (direction == 0) // движение вправо
            {
                for (j = left; j <= right; j++)
                {
                    spiralArray[index++] = array[top, j];
                }
                top++;
                direction = 1;
            }
            else if (direction == 1) // движение вниз
            {
                for (i = top; i <= bottom; i++)
                {
                    spiralArray[index++] = array[i, right];
                }
                right--;
                direction = 2;
            }
            else if (direction == 2) // движение влево
            {
                for (j = right; j >= left; j--)
                {
                    spiralArray[index++] = array[bottom, j];
                }
                bottom--;
                direction = 3;
            }
            else if (direction == 3) // движение вверх
            {
                for (i = bottom; i >= top; i--)
                {
                    spiralArray[index++] = array[i, left];
                }
                left++;
                direction = 0;
            }
        }

        Array.Sort(spiralArray);

        return spiralArray;
    }

    static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("{0} ", array[i, j]);
            }
            Console.Write(Environment.NewLine + Environment.NewLine);
        }
    }

    static void PrintArray(int[] array)
    {
        int length = array.Length;

        for (int i = 0; i < length; i++)
        {
            Console.Write("{0} ", array[i]);
        }

        Console.Write(Environment.NewLine + Environment.NewLine);
    }
```
