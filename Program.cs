/*using System;
using System.Collections.Generic;

namespace Independent_work_4_cs_4._11
{
    class Provider
    {
        private int PriceToConnect;
        private int Abonplata;
        private int InternetSpeed;
        private string NameOfTariff;

        Provider(string NameOfTariff, int PriceToConnect, int Abonplata, int InternetSpeed) 
        {
            this.NameOfTariff = NameOfTariff;
            this.PriceToConnect = PriceToConnect;
            this.Abonplata = Abonplata;
            this.InternetSpeed = InternetSpeed; 
        }

        public string getNameOfTariff()
        {
            return NameOfTariff;
        }
        public int getPriceToConnect()
        {
            return PriceToConnect;
        }
        public int getAbonplata()
        {
            return Abonplata;
        }
        public int getInternetSpeed()
        {
            return InternetSpeed;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Provider> ProviderList = getTariffs();

           












            Console.ReadLine();
        }
        public static Provider FindTariff()
        {
            

        }
        public static List<Provider> getTariffs()
        {
            List<Provider> TarrifList = new List<Provider>();

            TarrifList.Add(new Provider("Medium", 1500, 150, 50));
            return TarrifList;
        }
    }
}
*/

using System;
using System.Collections.Generic;

namespace Independent_work_4_cs_4._11
{
    class Provider
    {
        private int priceToConnect;
        private int abonplata;
        private int internetSpeed;
        private string nameOfTariff;

        public Provider(int priceToConnect, int abonplata, int internetSpeed, string nameOfTariff)
        {
            this.priceToConnect = priceToConnect;
            this.abonplata = abonplata;
            this.internetSpeed = internetSpeed;
            this.nameOfTariff = nameOfTariff;
        }

        public string getNameOfTariff()
        {
            return nameOfTariff;
        }
        public int getPriceToConnect()
        {
            return priceToConnect;
        }
        public int getAbonplata()
        {
            return abonplata;
        }
        public int getInternetSpeed()
        {
            return internetSpeed;
        }

        public override string ToString()
        {
            return "Provider={ priceToConnect=" + priceToConnect +
                    " abonplata=" + abonplata +
                    " internetSpeed=" + internetSpeed +
                    " nameOfTariff=" + nameOfTariff;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите желаемую скорость=");
            int speed = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите желаемую суму=");
            int abonplata = Convert.ToInt32(Console.ReadLine());

            if (findTariff(abonplata, speed).Count != 0)
            {
                Console.WriteLine("Подходящие нам провайдеры");
                foreach (Provider el in findTariff(abonplata, speed))
                    Console.WriteLine(el);
            }
            else Console.WriteLine("Не нашли ни одного подходящего провайдера");

        }
        public static List<Provider> findTariff(int abonplata, int speed)
        {
            List<Provider> suitableProvider = new List<Provider>();

            foreach (Provider el in getTariffs())
            {
                if (el.getInternetSpeed() == speed | el.getAbonplata() == abonplata)
                {
                    suitableProvider.Add(el);
                }
            }

            return suitableProvider;
        }
        public static List<Provider> getTariffs()
        {
            return new List<Provider>() {
            new Provider(1,2,5,"Бест"),
            new Provider(5, 1, 1, "вест"),
            new Provider(2,7, 6, "зест")
            };
        }
    }
}