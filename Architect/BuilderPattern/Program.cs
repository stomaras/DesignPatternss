using DAL;
using Repositories.Persistance;
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
           // UnitOfWork unit = new UnitOfWork(db);

            //var cars = unit.Cars.GetAll();
            //var motors = unit.Motors.GetAll();

            //foreach (var car in cars)
            //{
            //    Console.WriteLine(car.Name);
            //}

            //foreach (var motor in motors)
            //{
            //    Console.WriteLine(motor.Name);
            //}
            
        }
    }
}
