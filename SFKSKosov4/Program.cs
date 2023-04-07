using System.Globalization;
using System.Runtime.CompilerServices;

try
{
    int p;
    do
    {
        Console.WriteLine("Выберите задание от 1 до 3, чтобы выйти введите 0");
        Console.Write("Задание - ");

        p = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        switch (p)
        {
            case 0:
                { 
                    Console.WriteLine("Выход осуществлен");
                } 
                break;

            case 1:
                {
                    Console.Write("Введите число - ");
                    int Numb = Convert.ToInt32(Console.ReadLine());

                    int NumbPlus = Numb + 1;
                    int NumbMin = Numb - 1;

                    Console.WriteLine("Ответ: " + NumbMin + "" + Numb + "" + NumbPlus);
                    Console.WriteLine();
                    Console.WriteLine("========================================================================================================================");
                }
                break;

            case 2:
                {
                    Console.Write("Введите размер массива - ");
                    int X = Convert.ToInt32(Console.ReadLine());

                    int[] mass = new int[X];
                    Random rnd = new Random();

                    for (int i = 0; i < mass.Length; i++)
                    {
                        mass[i] = rnd.Next(-9, 10);
                    }

                    Console.Write("Массив: ");
                    for (int i = 0; i < mass.Length; i++)
                    {
                        Console.Write(mass[i] + " ");
                    }
                    Console.WriteLine();
                    Console.Write("Введите число - ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    int Numbers = X;
                    int kol = 1;
                    int u = 0;

                    do
                    {
                        if (u == mass.Length)
                        {
                            u = 0;
                            for (int i = 0; i < mass.Length; i++)
                            {
                                if (mass[i] == 666)
                                    Console.Write("-" + " ");
                                else
                                    Console.Write(mass[i] + " ");
                            }
                            Console.WriteLine();
                        }


                        if (mass[u] == 666)
                        {
                            kol--;
                        }


                        if (kol == n)
                        {
                            mass[u] = 666;
                            kol = 0;
                            Numbers--;
                        }



                        u++;
                        kol++;
                    }
                    while (Numbers != 1);

                    for (int i = 0; i < mass.Length; i++)
                    {
                        if (mass[i] == 666)
                            Console.Write("-" + " ");
                        else
                            Console.Write(mass[i] + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("========================================================================================================================");
                }
                break;

            case 3:
                {
                    Console.Write("Введите кол-во строк массива - ");
                    int M = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите кол-во столбцов массива - ");
                    int N = Convert.ToInt32(Console.ReadLine());

                    int[,] matrix = new int[M, N];
                    Random rnd = new Random();

                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            matrix[i, j] = rnd.Next(0, 10);
                        }
                    }

                    Console.WriteLine("Массив:");
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                        Console.WriteLine();
                    }

                    int Min;
                    int Temp = 0;
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        Min = matrix[i, 0];
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            if (matrix[i, j] <= Min)
                            {
                                Min = matrix[i, j];
                                Temp = j;
                            }
                        }
                        matrix[i, Temp] = matrix[i, i];
                        matrix[i, i] = Min;
                    }
                    Console.WriteLine();

                    Console.WriteLine("Отсортированный массив:");
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("========================================================================================================================");
                break;

            default:
                Console.WriteLine("Неверный номер задания");
                break;
        }
    }
    while (p != 0);
}
catch
{
    Console.WriteLine("========================================================================================================================");
    Console.WriteLine("КРИТИЧЕСКАЯ ОШИБКА!");
    Console.WriteLine("-Вводите корректные данные-");
    Console.WriteLine("[Требуется перезапуск программы]");
    Console.ReadLine();
}