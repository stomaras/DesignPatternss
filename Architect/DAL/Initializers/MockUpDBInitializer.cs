using DAL.Initializers.Seeders;
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

            List<ISeeder> seeders = new List<ISeeder>() { new Seeder() };

            SeedVehicles(seeders, context);
            
            base.Seed(context);
        }

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

    }
}
