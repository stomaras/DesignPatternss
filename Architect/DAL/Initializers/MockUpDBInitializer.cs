using DAL.Initializers.Seeders;
using DAL.Initializers.Seeders.VehiclePartsSeeders;
using Entities.VehicleParts;
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

            List<IVehiclePartSeeder> vehiclePartSeeders = new List<IVehiclePartSeeder>() { new VehiclePartSeeder() };

            SeedVehicleParts(vehiclePartSeeders, context);

            List<ISeeder> seeders = new List<ISeeder>() { new Seeder() };

            SeedVehicles(seeders, vehiclePartSeeders ,context);

           
            

            base.Seed(context);
        }

        #region Seed Vehicles

        #endregion
        private void SeedVehicles(List<ISeeder> seeders, List<IVehiclePartSeeder> vehiclePartSeeders, MainDBContext context)
        {
            foreach (var vehiclePartSeeder in vehiclePartSeeders)
            {
                var carEngines = vehiclePartSeeder.GetCarEngines();
                var carWheels = vehiclePartSeeder.GetCarWheels();
                var doors = vehiclePartSeeder.GetDoors();

                // motors parts
                var motorEngines = vehiclePartSeeder.GetMotorCycleEngines();
                var motorWheels = vehiclePartSeeder.GetMotorCycleWheels();
                foreach (var seeder in seeders)
                {
                    var cars = seeder.GetCars(doors, carEngines, carWheels);
                    var motors = seeder.GetMotorCycles(motorEngines, motorWheels);

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
                if (carWheels != null)
                {
                    context.Wheels.AddOrUpdate(carWheels.ToArray());
                }
                if (carEngines != null)
                {
                    context.Engines.AddOrUpdate(carEngines.ToArray());
                }
                if (motorWheels != null)
                {
                    context.WheelMotors.AddOrUpdate(motorWheels.ToArray());
                }
                if (motorEngines != null)
                {
                    context.EngineMotors.AddOrUpdate(motorEngines.ToArray());
                }

            }
         #endregion

        }
    }
}
