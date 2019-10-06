using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStrings
{
    struct Point
    {
        public int X;
        public int Y;

        public void Increment()
        {
            X++;
            Y++;
        }

        public void Decreent()
        {
            X--;
            Y--;
        }

        public void Display()
        {
            Console.WriteLine("X={0}, Y={1}",X,Y);
        }
        public Point(int XPOS, int YPos)
        {
            X = XPOS;
            Y = YPos;
        }
    }
    class Program
    {
        static void Main()
        {
            Point myPoint;
            myPoint.X = 349;
            myPoint.Y = 76;
            myPoint.Display();
            myPoint.Increment();
            myPoint.Display();

            Point p1 = new Point();
            p1.Display();

            Point p2 = new Point(50, 60);
            p2.Display();
        }
    }
}
