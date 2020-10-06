﻿using System;


namespace laba_4_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int N;
            int n = 1;
            Console.Write("Введите кол-во елементов в масиве: ");
            N = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[N];
            int[] b = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0,50);
            }

            Console.WriteLine("Массив перед сдвигом");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (i + n >= arr.Length)
                {
                    b[i + n - arr.Length] = arr[i];
                }
                else
                {
                    b[i + n] = arr[i];
                }
            }

            Console.WriteLine("Массив после сдвига");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(b[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
