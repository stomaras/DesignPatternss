using Entities;
using Entities.VehicleParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Initializers.Seeders
{
    public class Seeder : ISeeder
    {
        
        

        public List<Car> GetCars(List<Door> doors, List<Engine> engines, List<Wheel> wheels)
        {
            List<Car> cars = new List<Car>()
            {
                new Car()
                {
                    Name= "Porsche", Amount=100000, CreateDateTime = new DateTime(2000,01,01),
                    Wheels = new List<Wheel>(){ wheels[0],wheels[0], wheels[0],wheels[0]}, 
                    Doors = new List<Door>(){ doors[0], doors[0], doors[0], doors[0] },
                    Engine = engines[0]
                },
                new Car()
                {
                    Name= "Toyota", Amount=10000, CreateDateTime = new DateTime(1999,01,01),
                    Wheels = new List<Wheel>(){ wheels[1],wheels[1],wheels[1],wheels[1]},
                    Doors = new List<Door>(){ doors[1],doors[1],doors[1],doors[1]},
                    Engine = engines[1]
                },
                new Car()
                {
                    Name= "Audi", Amount=50000, CreateDateTime = new DateTime(2004,01,01),
                    Wheels = new List<Wheel>(){wheels[2],wheels[2],wheels[2],wheels[2]},
                    Doors = new List<Door>(){doors[2],doors[2],doors[2],doors[2]},
                    Engine = engines[2]
                },
                
            };

            return cars;
        }

        public List<MotorCycle> GetMotorCycles(List<EngineMotors> engineMotors, List<WheelMotors> wheelMotors)
        {
            List<MotorCycle> motorCycles = new List<MotorCycle>()
            {
                new MotorCycle()
                {
                    Name = "Venom", Amount = 30000, CreatedDateTime = new DateTime(2010,05,21),
                    EngineMotors = engineMotors[0],
                    WheelMotors = new List<WheelMotors>(){wheelMotors[0],wheelMotors[0]}
                },
                new MotorCycle()
                {
                    Name = "Black Lightning", Amount = 20000, CreatedDateTime = new DateTime(2011,05,21),
                    EngineMotors = engineMotors[1],
                    WheelMotors = new List<WheelMotors>(){wheelMotors[1],wheelMotors[1]}
                },
                new MotorCycle()
                {
                    Name = "X-75 Hurricance", Amount = 10000, CreatedDateTime = new DateTime(2012,05,21),
                    EngineMotors = engineMotors[2],
                    WheelMotors = new List<WheelMotors>(){wheelMotors[2],wheelMotors[2]}
                }
            };
            return motorCycles;
        }
    }
}
