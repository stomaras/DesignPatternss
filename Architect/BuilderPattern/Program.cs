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
            UnitOfWork unit = new UnitOfWork(db);


            var cars = unit.Cars.GetCarsWithEverything();

            //var doorsOfCar = cars.Select(x => x.Doors);
            //var engineOfCar = cars.Select(x => x.Engine);
            //var wheelsOfCar = cars.Select(x => x.Wheels);

            //foreach (var car in cars)
            //{
            //    Console.WriteLine($"Car with name {car.Name}, with price {car.Amount}, with engine {car.Engine.Type}");
            //}

            //var carr = unit.Cars.GetById(1);

            var car = unit.Cars.GetCarWithEverything(2);

            Console.WriteLine($"Car with name {car.Name}, amount {car.Amount}, with engine type {car.Engine.Type}");
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
