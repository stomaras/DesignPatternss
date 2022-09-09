using Entities.VehicleParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Initializers.Seeders.VehiclePartsSeeders
{
    public interface IVehiclePartSeeder
    {
        List<Engine> GetCarEngines();
        List<EngineMotors>  GetMotorCycleEngines();
        List<Door> GetDoors();
        List<Wheel> GetCarWheels();
        List<WheelMotors> GetMotorCycleWheels();
    }
}
