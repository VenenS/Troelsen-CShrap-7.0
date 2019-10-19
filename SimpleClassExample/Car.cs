using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Car
    {
        public string petName;
        public int currSpeed;

        public Car()
        {
            petName = "Chuck";
            currSpeed = 10;
        }

        public Car(string pn)
        {
            petName = pn;
        }

        public Car(string pn, int cs)
        {
            petName = pn;
            currSpeed = cs;
        }

        public void PrintState() => Console.WriteLine("{0} is going {1} MPH.", petName, currSpeed);
        public void SpeedUP(int delta) => currSpeed += delta;
    }
    class Motorcycle
    {
        public string driverName;
        public int driverIntensity;
        public void PopAwheely()
        {
            for (int i = 0; i < driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeeeeeeee Haaaaaaaaaeewww!");
            }
        }
        public void SetDriverName(string name)
        {
            driverName = name;
        }
        public Motorcycle() { }
        public Motorcycle(int intensity)
        {
            SetIntensity(intensity);
        }
        public Motorcycle(int intensity, string name)
        {
            SetIntensity(intensity);
        }
        public void SetIntensity(int intensity)
        {
            if (intensity > 10)
                intensity = 10;
            driverIntensity = intensity;
        }
        
    }
}
