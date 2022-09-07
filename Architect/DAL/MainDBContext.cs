using DAL.Initializers;
using Entities;
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
    }
}
