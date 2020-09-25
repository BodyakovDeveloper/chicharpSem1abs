using System;

namespace Laba_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double u = 0, S = 1;
            int start, end;

            Console.WriteLine("Введите начальное значение: ");
            do
            {
                start = Convert.ToInt32(Console.ReadLine());
                if (start < 0)
                {
                    Console.WriteLine("Введите другое значение: ");
                }
            } while (start < 0);

            Console.WriteLine("Введите значения за которое нельзя перейти: ");
            do
            {
                end = Convert.ToInt32(Console.ReadLine());
                if (end < start)
                {
                    Console.WriteLine("Введите другое значение: ");
                }
            } while (end < start);

            for (int i = start; i <= end; i++)
            {
                u = (i * i - Math.Pow(-1, i * i + 1) * i) / (Math.Pow(i, 2) + 2);
                S *= u;
                Console.WriteLine("u" + i + "=" + u);
                u = 0;
            }
            Console.WriteLine("Произведение ряда = " + S);

            Console.ReadLine();
        }
    }
}
