using System;
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
            Car chuck = new Car();
            chuck.PrintState();

            Car mary = new Car("MAry");
            mary.PrintState();

            Car daisy = new Car("Daisy", 75);
            daisy.PrintState();

            Motorcycle c = new Motorcycle(5);
            c.SetDriverName("Tiny");
            c.PopAwheely();
            Console.WriteLine(c.name);
        }
    }
}
