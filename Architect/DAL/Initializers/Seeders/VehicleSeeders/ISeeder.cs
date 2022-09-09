using Entities;
using Entities.VehicleParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Initializers.Seeders
{
    public interface ISeeder
    {
        List<Car> GetCars(List<Door> doors, List<Engine> engines, List<Wheel> wheels);
        List<MotorCycle> GetMotorCycles(List<EngineMotors> engineMotors, List<WheelMotors> wheelMotors);
    }
}
