using System;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            Money num = new Money();
            Console.WriteLine($"Номинал купюры = {num.FIRST}");
            Console.WriteLine($"Количество номинала = {num.SECOND}");
            num.GetData();
            Console.WriteLine(num.Summ);
            Console.WriteLine($"Цена товара равна: {num.N} azn");
            num.GetCompare();
            num.GetQuantity();
            string report = ("номинал");
            num.FIRST = NumsInput(report);
            report = ("количество номинала");
            num.SECOND = NumsInput(report);
            num.GetData();
            Console.WriteLine(num.Summ);
            Console.WriteLine($"Цена товара равна: {num.N} azn");
            num.GetCompare();
            num.GetQuantity();
            Console.WriteLine("Для продолжения нажмите любую клавишу!");
                            Console.ReadKey();
        }
        static int NumsInput(string report)
        {
            int nums = 0;
            Console.Write($"Введите {report}: ");
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out nums))
            {
                if (nums > 0)
                    return nums;
                else
                {
                    Console.WriteLine("Введите положительное число!");
                    return NumsInput(report);
                }
            }
            else
            {
                Console.WriteLine("Введите число!");
                return NumsInput(report);
            }
        }
    }
    class Money
    {
        public int FIRST { get; set; }
        public int SECOND { get; set; }
        public int N = 120;
        private string summ;
        public string Summ
        {
            get
            {
                return $"Сумма ваших денег равна: {FIRST * SECOND} azn";
            }
        }
        public Money()
        {
            FIRST = 10;
            SECOND = 3;
        }
        public Money(int first, int second)
        {
            FIRST = first;
            SECOND = second;
        }
        public void GetData()
        {
            Console.WriteLine($"Номинал = {FIRST} \tКоличество номинала = {SECOND}");
        }
        public void GetCompare()
        {
            int num = FIRST * SECOND;
            if (num >= N) { }
            else
            {
                Console.WriteLine("У вас не хватает денег на покупку данного товара.");
            }
        }
        public void GetQuantity()
        {
            int num = FIRST * SECOND;
            if (num >= N)
            {
                int quantity = num / N;
                Console.WriteLine($"На ту сумму денег которая есть у вас, можно купить {quantity} штук данного товара.");
            }
            else { }
        }
    }
}
