using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Initializers.Seeders
{
    public class Seeder : ISeeder
    {
        public List<Car> GetCars()
        {
            List<Car> cars = new List<Car>()
            {
                new Car(){Name= "Porsche", Amount=100000, CreateDateTime = new DateTime(2000,01,01) },
                new Car(){Name= "Toyota", Amount=10000, CreateDateTime = new DateTime(1999,01,01) },
                new Car(){Name= "Audi", Amount=50000, CreateDateTime = new DateTime(2004,01,01) },
                new Car(){Name= "Mercedes", Amount=60000, CreateDateTime = new DateTime(2000,01,01) },
            };

            return cars;
        }

        public List<MotorCycle> GetMotorCycles()
        {
            List<MotorCycle> motorCycles = new List<MotorCycle>()
            {
                new MotorCycle(){Name = "Venom", Amount = 30000, CreatedDateTime = new DateTime(2010,05,21)},
                new MotorCycle(){Name = "Black Lightning", Amount = 20000, CreatedDateTime = new DateTime(2011,05,21)},
                new MotorCycle(){Name = "X-75 Hurricance", Amount = 10000, CreatedDateTime = new DateTime(2012,05,21)}
            };
            return motorCycles;
        }
    }
}
