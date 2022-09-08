using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternss.BuilderVehicles
{
    public abstract class VehicleBuilder
    {
        protected Vehicle vehicle;

        // Get Vehicle Instance
        public Vehicle Vehicle
        {
            get { return vehicle; }
        }

        //Abstract Build Methods
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
}
