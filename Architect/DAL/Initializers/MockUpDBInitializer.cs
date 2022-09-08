using DAL.Initializers.Seeders;
using DAL.Initializers.Seeders.VehiclePartsSeeders;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Initializers
{
    public class MockUpDBInitializer : DropCreateDatabaseAlways<MainDBContext>
    {
        protected override void Seed(MainDBContext context)
        {

            //List<ISeeder> seeders = new List<ISeeder>() { new Seeder() };

            //List<IVehiclePartSeeder> vehiclePartSeeders = new List<IVehiclePartSeeder>() { new VehiclePartSeeder() };

            //SeedVehicleParts(vehiclePartSeeders, context);
            //SeedVehicles(seeders, context);
            
            base.Seed(context);
        }

        #region Seed Parts Of Vehicle
        public void SeedVehicleParts(List<IVehiclePartSeeder> vehiclePartSeeders, MainDBContext context)
        {
            foreach (var vehicleParts in vehiclePartSeeders)
            {
                var carWheels = vehicleParts.GetCarWheels();
                var carEngines = vehicleParts.GetCarEngines();
                var doors = vehicleParts.GetDoors();
                var motorWheels = vehicleParts.GetMotorCycleWheels();
                var motorEngines = vehicleParts.GetMotorCycleEngines();

                if (doors != null)
                {
                    context.Doors.AddOrUpdate(doors.ToArray());
                }
            }
        }
        #endregion

        #region Seed Vehicles
        public void SeedVehicles(List<ISeeder> seeders, MainDBContext context)
        {
            foreach (var vehicles in seeders)
            {
                var cars = vehicles.GetCars();
                var motors = vehicles.GetMotorCycles();

                if (cars != null)
                {
                    context.Cars.AddOrUpdate(cars.ToArray());
                }

                if (motors != null)
                {
                    context.MotorCycles.AddOrUpdate(motors.ToArray());
                }
            }
        }
        #endregion


        #region Get Parts Of Vehicles
        public void GetParts(List<IVehiclePartSeeder> vehiclePartSeeders)
        {
            foreach (var vehicleParts in vehiclePartSeeders)
            {
                var carWheels = vehicleParts.GetCarWheels();
                var carEngines = vehicleParts.GetCarEngines();
                var doors = vehicleParts.GetDoors();
                var motorWheels = vehicleParts.GetMotorCycleWheels();
                var motorEngines = vehicleParts.GetMotorCycleEngines();
            }
        }
        #endregion
    }
}
