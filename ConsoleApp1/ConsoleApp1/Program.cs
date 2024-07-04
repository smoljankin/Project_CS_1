using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        public string Name { set; get; }
        public DateTime Age { set; get; }
    }
    class Program
    {
        static int Min(int a, int b)
        {
            if (a < b) return a;
            else return b;
        }
        static void Main(string[] args)
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            Console.WriteLine(Min(a, b));


            Person p = new Person { Name = "Kostia", Age = new DateTime(2000, 1, 10) };

            Point point = new Point(10, 20);

            point++;

            Console.WriteLine(point);

            ++point;

            Console.WriteLine(point);

            Point point2 = new Point(50, 60);

            Point point3 = point + point2;

            Console.WriteLine(point3);
        }
    }

    class Point
    {
        int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static Point operator ++(Point p)
        {
            p.x++;
            p.y++;
            return p;
        }

        public static Point operator + (Point p1, Point p2)
        {
            Point p = new Point(p1.x, p1.y);
            p.x += p2.x;
            p.y += p2.y;
            return p;
        }

        public override string ToString()
        {
            return x + " " + y;
        }
    }
}
