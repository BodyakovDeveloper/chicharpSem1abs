using System;

namespace Laba_2
{
    class Program
    {
        static void Main(string[] args)
        {
			int Num, n1, n2, n3, sum;
            Console.Write("enter a three-digit number:");
			Num = Int32.Parse(Console.ReadLine());
			n1 = Num / 100;
			n2 = Num / 10 - n1 * 10;
			n3 = Num % 10;
			sum = n1 + n2 + n3;
            Console.WriteLine("Sum of numbers: " + sum);
            if ( (sum % 2) == 0)
            {
                Console.WriteLine("Сумма чисел трехзначного числа парная");
            }
            else 
			{
				Console.WriteLine("Сумма чисел трехзначного числа непарная");
			}
			Console.ReadLine();
		}
	}
}

