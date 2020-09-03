using System;

namespace Zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            DupletArray num = new DupletArray();
            Console.WriteLine("Элементы массива до сортировки");
            num.GetData();
            Console.WriteLine("Элементы массива после сортировки");
            // не успел!!!
            Console.WriteLine("Количество элементов массива равно: 6");
            string report = "ранг массива";
            num.N = NumsInput(report);
            report = "размерность массива";
            num.M = NumsInput(report);
            num.DoubleArray = new double[num.N, num.M];
            for (int i = 0; i < num.N; i++)
            {
                Console.WriteLine($"Введите элементы массива {i + 1}-го ранга");
                for (int j = 0; j < num.M; j++)
                {
                    num.DoubleArray[i, j] = ArrayInput();
                }
            }
            report = "скаляр";
            num.Scalar = ScalarInput();
            num.GetScalar();
            Console.WriteLine("Элементы массива до сортировки");
            num.GetData();
            Console.WriteLine("Элементы массива после сортировки");
            Console.WriteLine(num.Quantity);

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
        static double ArrayInput()
        {
            double nums;
            Console.Write($"Введите число: ");
            string input = Console.ReadLine();
            if (Double.TryParse(input, out nums))
                return nums;
            else
            {
                Console.WriteLine("Введите число!");
                return ArrayInput();
            }
        }
        static double ScalarInput()
        {
            double nums = 0;
            Console.WriteLine("Введите скаляр");
            string input = Console.ReadLine();
            if (Double.TryParse(input, out nums))
            {
                if (nums > 0)
                    return nums;
                else
                {
                    Console.WriteLine("Введите положительное число!");
                    return ScalarInput();
                }
            }
            else
            {
                Console.WriteLine("Введите число!");
                return ScalarInput();
            }
        }
    }
    class DupletArray
    {
        public double[,] DoubleArray { get; set; }
        public int N { get; set; }
        public int M { get; set; }
        public string Quantity
        {
            get
            {
                return $"Количество элементов массива равно: {N * M}";
            }
        }
        private int scalar;
        public double Scalar
        {
            set
            {
                scalar = (int)value;
            }
        }
        public DupletArray()
        {
            N = 2;
            M = 3;
            DoubleArray = new double[2, 3] { { 23, -45, 456 }, { 6, 123, -45 } };

        }
        public DupletArray(int n, int m)
        {
            DoubleArray = new double[n, m];
        }
        public void GetScalar()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    DoubleArray[i, j] = DoubleArray[i, j] * scalar;
                }
            }
        }
        public void GetData()
        {
            foreach (int numbers in DoubleArray)
            {
                Console.WriteLine($"{numbers}\t");
            }
        }
        static int[] BubbleSort(int[] nums) //create bubble method
        {
            int temp;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            return nums;

        }
    }
}
