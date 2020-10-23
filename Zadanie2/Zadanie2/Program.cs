using System;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle num = new Triangle();
            Console.WriteLine($"Сторона a равна: {num.A}");
            Console.WriteLine($"Сторона b равна: {num.B}");
            Console.WriteLine($"Сторона c равна: {num.C}");
            num.GetData();
            num.GetPerimeter();
            num.GetArea();
            string report = ("A");
            num.A = SideInput(report);
            report = ("B");
            num.B = SideInput(report);
            report = ("C");
            num.C = SideInput(report);
            num.GetData();
            num.GetPerimeter();
            num.GetArea();
            Console.WriteLine(num.Side);
            Console.WriteLine("Для продолжения нажмите любую клавишу!");
                            Console.ReadKey();

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

    class Triangle
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        private string side;
        public string Side
        {
            get
            {
                if (A + B <= C)
                {
                    return "Треугольник с такими сторонами не существует. \nСумма двух сторон треугольника не должна быть меньше третьей!";
                }
                else if (A + C <= B)
                {
                    return "Треугольник с такими сторонами не существует. \nСумма двух сторон треугольника не должна быть меньше третьей!";
                }
                else if (C + B <= A)
                {
                    return "Треугольник с такими сторонами не существует. \nСумма двух сторон треугольника не должна быть меньше третьей!";
                }
                else
                    return side;
            }
        }

        public Triangle()
        {
            A = 3;
            B = 4;
            C = 5;
        }
        public Triangle(int a, int b, int c)
        {
            A = a;
            a = Convert.ToInt32(Console.ReadLine());
            B = b;
            b = Convert.ToInt32(Console.ReadLine());
            C = c;
            c = Convert.ToInt32(Console.ReadLine());
        }
        public void GetData()
        {
            if (A + B <= C) { }
            else if (A + C <= B) { }
            else if (C + B <= A) { }
            else
            {
                Console.WriteLine($"Длинна стороны a равна {A}, стороны b = {B}, стороны c = {C}");
            }
        }
        public void GetPerimeter()
        {
            if (A + B <= C) { }
            else if (A + C <= B) { }
            else if (C + B <= A) { }
            else
            {
                double perimeter = A + B + C;
                Console.WriteLine($"Периметр данного треугольника равен: {perimeter}");
            }
        }
        public void GetArea()
        {
            if (A + B <= C) { }
            else if (A + C <= B) { }
            else if (C + B <= A) { }
            else
            {
                double pp = (double)(A + B + C) / 2;
                double area = Math.Sqrt(pp * (pp - A) * (pp - B) * (pp - C));
                Console.WriteLine($"Площадь данного треугольника равна: {area}");
            }
        }
    }
}
