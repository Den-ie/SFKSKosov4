int p;
do
{
    Console.WriteLine("Выберите задание от 1 до 3, чтобы выйти введите 0");
    Console.Write("Задание - ");

    p = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    switch (p)
    {
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

        default:
            Console.WriteLine("Неверный номер задания");
            break;
    }
}
while (p != 0);