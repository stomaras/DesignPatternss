using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MainDBContext db = new MainDBContext();

            var cars = db.Cars;

            var motors = db.MotorCycles;

            foreach (var car in cars)
            {
                Console.WriteLine(car.Name);
            }

            foreach (var motor in motors)
            {
                Console.WriteLine(motor.Name);
            }
            
        }
    }
}
