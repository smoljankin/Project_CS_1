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

        public override string ToString()
        {
            return x + " " + y;
        }
    }
}
