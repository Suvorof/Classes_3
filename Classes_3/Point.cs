using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_3
{
    class Point
    {
        string name;
        int x, y;
        public int X
        {
            get
            {
                return x;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public Point()
            : this("", 0, 0) { }
        public Point(string name, int x, int y)
        {
            this.name = Console.ReadLine();
            Console.WriteLine("Введите координату X:");
            this.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату Y:");
            this.y = int.Parse(Console.ReadLine());
        }
    }
}
