using Entities.VehicleParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Car : Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public DateTime CreateDateTime { get; set; }

        public ICollection<Door> Doors { get; set; }
        public ICollection<Wheel> Wheels { get; set; }
        public Engine Engine { get; set; }

        public Car()
        {
            Doors = new HashSet<Door>();
            Wheels = new HashSet<Wheel>();
            Engine = new Engine();
        }
    }
}
