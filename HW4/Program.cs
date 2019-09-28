using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[2];
            for (var i = 0; i < cars.Length; i++)
            {
                cars[i] = new Car();
                cars[i].Init();
            }
            foreach (var car in cars)
            {
                car.Show();
            }
            Console.ReadKey();
        }
    }
}
