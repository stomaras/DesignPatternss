using Entities.VehicleParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Initializers.Seeders.VehiclePartsSeeders
{
    public class VehiclePartSeeder : IVehiclePartSeeder
    {

        #region Seed Car Engines
        public List<Engine> GetCarEngines()
        {
            List<Engine> carEngines = new List<Engine>()
            {
                new Engine(){Type="Naturally aspirated engine", NumOfGears = 5},
                new Engine(){Type="Naturally aspirated engine", NumOfGears = 6},
                new Engine(){Type="Turbocharged engine", NumOfGears = 6},
                new Engine(){Type="Turbocharged engine", NumOfGears = 5},
                new Engine(){Type="CRDi engine", NumOfGears = 6},
                new Engine(){Type="CRDi engine", NumOfGears = 5},

            };

            return carEngines;
        }

        #endregion

        

        #region Seed Doors
        public List<Door> GetDoors()
        {
            List<Door> doors = new List<Door>()
            {
                new Door(){Type="Scissor Doors", Price=10},
                new Door() { Type = "Gull-Wing Doors", Price = 14 },
                new Door() { Type = "Butterfly Doors", Price = 20 },
                new Door() { Type = "Suicide Doors", Price = 30 },
                new Door() { Type = "Sliding Doors", Price = 40 },
                new Door() { Type = "Pocket Doors", Price = 20 },
                new Door() { Type = "Swan Doors", Price = 15 },
                new Door() { Type = "Canopy Doors", Price = 17 }
            };

            return doors;
        }
        #endregion

        #region Seed MotorCycle Engines
        public List<Engine> GetMotorCycleEngines()
        {
            List<Engine> motorCycleEngines = new List<Engine>()
            {
                new Engine(){Type= "Two - Stroke and four-stroke", NumOfGears = 5},
                new Engine(){Type= "Cylinder Heads", NumOfGears = 5},
                new Engine(){Type= "Valve control in four-strokes", NumOfGears = 5},
                new Engine(){Type= "Unit Construction", NumOfGears = 5},
                new Engine(){Type= "Cylinders and Configuration", NumOfGears = 5},
            };
            return motorCycleEngines;
        }
        #endregion

        #region Seed Car Wheels
        public List<Wheel> GetCarWheels()
        {
            List<Wheel> carWheels = new List<Wheel>()
            {
                new Wheel(){Type = "Alloy Wheels"},
                new Wheel(){Type = "Steel Wheels"},
                new Wheel(){Type = "Forged and Cast Wheels"},
                new Wheel(){Type = "Rim Wheels"}
            };

            return carWheels;
        }

        #endregion



        #region Seed MotorCycleWheels
        public List<Wheel> GetMotorCycleWheels()
        {
            var wheels = new List<Wheel>()
            {
                new Wheel(){Type="Spoked Wheels"},
                new Wheel(){Type="Cast Wheels"},
                new Wheel(){Type="Magnesium alloy wheels"},
                new Wheel(){Type="Composite Wheels"}
            };
            return wheels;
        }
        #endregion


        #region All Wheels
        public List<Wheel> GetWheels()
        {
            List<Wheel> carwheels = GetCarWheels();
            List<Wheel> motorWheels = GetMotorCycleWheels();
            List<Wheel> totalWheels = new List<Wheel>();
            totalWheels.AddRange(carwheels);
            totalWheels.AddRange(motorWheels);
            return totalWheels;
        }
        #endregion


    }
}
