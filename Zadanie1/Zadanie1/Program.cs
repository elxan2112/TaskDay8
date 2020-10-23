using System;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point num1 = new Point();
            Console.WriteLine($"Начальная абцисса равна: {num1.X}");
            Console.WriteLine($"Начальная ордината равна: {num1.Y}");
            num1.GetPoint();
            num1.GetDistance();
            num1.GetQuarter();
            string comments = "абцису (х)";
            num1.X = NumInput(comments);
            comments = "ординату (y)";
            num1.Y = NumInput(comments);
            num1.GetPoint();
            num1.GetDistance();
            num1.GetQuarter();
            Console.WriteLine("Для продолжения нажмите любую клавишу!");
                            Console.ReadKey();

        }

        static int NumInput(string comment)
        {
            int nums = 0;
            Console.Write($"Введите {comment}: ");
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out nums))
                return nums;
            else
            {
                Console.WriteLine("vvedite cislo");
                return NumInput(comment);
            }

        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point()
        {
            X = 0;
            Y = 0;
        }
        public Point(int x, int y)
        {
            X = x;
            x = Convert.ToInt32(Console.ReadLine());
            Y = y;
            y = Convert.ToInt32(Console.ReadLine());
        }
        public void GetPoint()
        {
            Console.WriteLine($"Абцисса {X}, ордината {Y}");
        }
        public void GetDistance()
        {
            double distance = Math.Sqrt((X * X) + (Y * Y));
            Console.WriteLine($"Расстояние от начала до точки равно = {distance}");
        }

        public void GetQuarter()
        {
            if (X > 0 && Y > 0)
            {
                Console.WriteLine("Первая четверть.");
            }
            else if (X < 0 && Y > 0)
            {
                Console.WriteLine("Вторая четверть.");
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine("Третья четверть.");
            }
            else if (X > 0 && Y < 0)
            {
                Console.WriteLine("Четвертая четверть.");
            }
            else
            {
                Console.WriteLine("Точка нахожится на начале оси координат.");
            }
        }
    }
}
