﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.petName = "Henry";
            myCar.currSpeed = 10;
            for (int i = 0; i <=10; i++)
            {
                myCar.SpeedUP(5);
                myCar.PrintState();
            }
            Console.ReadLine();
        }
    }
}
