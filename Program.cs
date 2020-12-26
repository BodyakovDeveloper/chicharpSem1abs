using System;

namespace ConsoleApp3
{
       
    class Program
    {
        static void AddLast(ref int[] arr, int value)
        {
            int[] newArray = new int[arr.Length + 1];

            newArray[arr.Length] = value;

            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i] = arr[i];
            }
            arr = newArray;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 25, 38, 4, 100, 200, 45, 13, 100, 4 };

            Console.WriteLine("Array before adding the last element:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}; ");
            }
            AddLast(ref arr, 1000);

            Console.WriteLine("\n\nArray after adding the last element:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}; ");
            }

            Console.ReadLine();
        }
    }
}
