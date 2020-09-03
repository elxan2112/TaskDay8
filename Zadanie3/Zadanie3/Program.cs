using System;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle num = new Rectangle();
            Console.WriteLine($"Сторона a равна {num.A}");
            Console.WriteLine($"Сторона b равна {num.B}");
            num.GetData();
            num.GetPerimeter();
            num.GetArea();
            string report = "a";
            num.A = SideInput(report);
            report = "b";
            num.B = SideInput(report);
            num.GetData();
            num.GetPerimeter();
            num.GetArea();
            Console.WriteLine(num.Meaning);
        }
        static int SideInput(string report)
        {
            int side = 0;
            Console.Write($"Введите значение стороны {report}: ");
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out side))
            {
                if (side > 0)
                    return side;
                else
                {
                    Console.WriteLine("Введите положительное число!");
                    return SideInput(report);
                }
            }
            else
            {
                Console.WriteLine("Введите число!");
                return SideInput(report);
            }
        }
    }

    class Rectangle
    {
        public int A { get; set; }
        public int B { get; set; }
        private string meaning;
        public string Meaning
        {
            get
            {
                if (A == B)
                {
                    return "Данный четырёхугольник является квадратом.";
                }
                else
                {
                    return meaning;
                }
            }
        }
        public Rectangle()
        {
            A = 5;
            B = 10;
        }
        public Rectangle(int a, int b)
        {
            A = a;
            B = b;
        }
        public void GetData()
        {
            Console.WriteLine($"Сторона a = {A}, b = {B}");
        }
        public void GetPerimeter()
        {
            int pp = (A + B) * 2;
            Console.WriteLine($"Периметр данного четырёхугольника равен: {pp}");
        }
        public void GetArea()
        {
            int area = A * B;
            Console.WriteLine($"Площадь данного четырёхугольника равна: {area}");
        }
    }
}
