using Contexts.Initializers;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contexts
{
    public class EmpPortalContext : DbContext
    { 
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }

        public EmpPortalContext() : base("Sindesmos")
        {
            Database.SetInitializer<EmpPortalContext>(new MockupDbInitializer());
            Database.Initialize(false);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasRequired(s => s.EmployeeType)
                .WithMany(g => g.Employees).HasForeignKey<int>(s => s.EmployeeTypeId);

            //modelBuilder.Entity<Employee>().Ignore(c => c.Bonus);
            
            base.OnModelCreating(modelBuilder);
        }

        
    }
}
