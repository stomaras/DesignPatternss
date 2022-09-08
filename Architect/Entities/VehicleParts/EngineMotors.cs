using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.VehicleParts
{
    public class EngineMotors : Vehicle
    {
        public int Id { get; set; }
        public string  Type { get; set; }
        public int NumOfGears { get; set; }
    }
}
