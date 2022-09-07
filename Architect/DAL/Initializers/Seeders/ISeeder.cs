using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Initializers.Seeders
{
    public interface ISeeder
    {
        List<Car> GetCars();
        List<MotorCycle> GetMotorCycles();
    }
}
