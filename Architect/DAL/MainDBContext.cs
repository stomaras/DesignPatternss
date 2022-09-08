using DAL.Initializers;
using Entities;
using Entities.VehicleParts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MainDBContext : DbContext
    {
        public MainDBContext():base("MainDbConnection")
        {
            Database.SetInitializer<MainDBContext>(new MockUpDBInitializer());
            Database.Initialize(false);
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<MotorCycle> MotorCycles { get; set; }
        public DbSet<Door> Doors { get; set; }
        public DbSet<Wheel> Wheels { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<EngineMotors> EngineMotors { get; set; }
        public DbSet<WheelMotors> WheelMotors { get; set; }
    }
}
