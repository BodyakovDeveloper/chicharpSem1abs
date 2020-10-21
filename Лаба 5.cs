using System;

namespace Laba__5_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
           /* byte m,n;
            Console.Write("Введите кол-во строк в масиве: ");
            m = Convert.ToByte(Console.ReadLine());
            Console.Write("Введите кол-во столбиков в масиве: ");
            n = Convert.ToByte(Console.ReadLine());
            */
            const byte m = 5;
            const byte n = 5;
            
            int[,] arr = new int[m,n];
            int[] farr = new int[m];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i,j] = rnd.Next(-10, 50);
                }
            }
            Console.WriteLine("\n Наш массив:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j] + ", "); 
                }
                Console.Write("\n");
            }
            byte NumOfSuitableCol = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i, j] > 0)
                    {
                        farr[i] += 1;
                    }
                }
                if (farr[i] == n)
                {
                    NumOfSuitableCol += 1;
                }
            }
            Console.WriteLine("\nколичество подходящих строчек: " + NumOfSuitableCol);
            if (NumOfSuitableCol == 1)
            {
                for (int i = 0; i < m; i++)
                {
                    if (farr[i] == n)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(arr[i, j] + ", ");
                        }
                    }
                    Console.WriteLine("\n");
                }
            }
            else if (NumOfSuitableCol > 1)
            {
                for (int i = 0; i < m; i++)
                {
                    if (farr[i] == n)
                    {
                        Console.WriteLine("Первая подходящая строчка: ");
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(arr[i, j] + ", ");
                        }
                        break;
                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine();
                for (int i = m - 1; i > 0; i--)
                {
                    if (farr[i] == n)
                    {
                        Console.WriteLine("Последняя подходящая строчка: ");
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(arr[i, j] + ", ");
                        }
                        break;
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("0");
            }
            Console.ReadLine();
        }
    }
}
