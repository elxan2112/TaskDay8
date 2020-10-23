using System;

namespace Zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrayy num = new Arrayy();
            Console.WriteLine("Элементы массива до сортировки");
            num.GetData();
            Console.WriteLine("Элементы массива после сортировки");
            num.GetSort();
            Console.WriteLine(num.dimension);
            string report = "размерность массива";
            num.N = NumsInput(report);
            num.IntArray = new int[num.N];
            for (int i = 0; i < num.N; i++)
            {
                num.IntArray[i] = ArrayInput();
            }
            report = "скаляр";
            num.Scalar = NumsInput(report);
            num.GetScalar();
            Console.WriteLine(num.dimension);
            Console.WriteLine("Элементы массива до сортировки");
            num.GetData();
            Console.WriteLine("Элементы массива после сортировки");
            num.GetSort();
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
        static int ArrayInput()
        {
            int nums;
            Console.Write($"Введите число: ");
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out nums))
                return nums;
            else
            {
                Console.WriteLine("Введите число!");
                return ArrayInput();
            }
        }
    }
    class Arrayy
    {
        public int[] IntArray { get; set; }
        public int N { get; set; }
        public string dimension
        {
            get
            {
                return $"Размерность нашего массива равна {N}";
            }
        }
        private int scalar;
        public int Scalar
        {
            set
            {
                scalar = value;
            }
        }
        public Arrayy()
        {
            IntArray = new int[6] { 21, 11, 45, 6, -63, 9 };
            N = 6;
        }
        public Arrayy(int n)
        {
            IntArray = new int[n];
        }
        public void GetScalar()
        {
            for (int i = 0; i < N; i++)
            {
                IntArray[i] = IntArray[i] * scalar;
            }
        }
        public void GetSort()
        {
            Array.Sort(IntArray);
            foreach (int numbers in IntArray)
            {
                Console.Write($"{numbers}\t");
            }
            Console.WriteLine("");
        }
        public void GetData()
        {
            foreach (int numbers in IntArray)
            {
                Console.Write($"{numbers}\t");
            }
            Console.WriteLine("");
        }
    }
}
