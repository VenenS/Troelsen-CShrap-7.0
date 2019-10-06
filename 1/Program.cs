using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(7, 5);
            var pointValues = p.Deconstruct();
            Console.WriteLine(pointValues.XPos);
            Console.WriteLine(pointValues.YPos);
        }
    }
    struct Point
    {
        public int X;
        public int Y;
        public Point(int XPos, int YPos)
        {
            X = XPos;
            Y = YPos;
        }
        public (int XPos, int YPos) Deconstruct() => (X, Y);
    }
}
