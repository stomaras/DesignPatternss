using Entities.VehicleParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class MotorCycle : Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        
        public DateTime CreatedDateTime { get; set; }

        public ICollection<WheelMotors> WheelMotors { get; set; }
        public EngineMotors EngineMotors { get; set; }

        public MotorCycle()
        {
            WheelMotors = new HashSet<WheelMotors>();
            EngineMotors = new EngineMotors();
        }
    }
}
