using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_3
{
    class Figure
    {
        int number;
        Point[] points;
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public void InitializeFigure()
        {
            Console.WriteLine("Введите количество вершин многоугольника");
            number = int.Parse(Console.ReadLine());
            if (number == 2)
            {
                Console.WriteLine("Многоугольник должен состоять минимум из 3-х вершин");
                Console.WriteLine("Программа будет завершена после нажатия любой клавиши");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Вы создали {0}-х угольник", number);
            }

            points = new Point[number];
            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine("Введите букву которой обозначается {0} точка:", i + 1);
                points[i] = new Point();             
            }

        }
        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
        public double CalculatePerimeter()
        {
            double perimeter = 0;
            for (int i = 1; i < points.Length; i++)
            {
                perimeter += this.LengthSide(points[i - 1], points[i]);
            }
            perimeter += this.LengthSide(points[0], points[points.Length-1]);
            Console.Write("Периметр {0}-х угольника равен: ", number);
            return perimeter;
        }
        public Figure(string name)
        {
            InitializeFigure();
        }
    }
}
