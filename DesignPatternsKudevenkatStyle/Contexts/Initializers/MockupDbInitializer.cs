using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contexts.Initializers
{
    internal class MockupDbInitializer : DropCreateDatabaseAlways<EmpPortalContext>
    {

        protected override void Seed(EmpPortalContext context)
        {
            #region Seed EmployeeType

            EmployeeType empTypeContract = new EmployeeType() 
            { 
                Id = 1, 
                Type = "Contract" 
            };

            EmployeeType empTypePermanent = new EmployeeType() 
            {
                Id = 2,
                Type = "Permanent" 
            };

            context.EmployeeTypes.AddOrUpdate(empTypeContract, empTypePermanent);
            context.SaveChanges();
            #endregion

            #region Seed Employees
            Employee emp1 = new Employee()
            {
                Id = 1,
                FirstName = "Spyros",
                LastName = "Tomaras",
                Department = "IT",
                JobDescription = "Junior Software Enginner",
                EmployeeTypeId = 1
            };
            Employee emp2 = new Employee()
            {
                Id = 2,
                FirstName = "Agathi",
                LastName = "Tomara",
                Department = "Marketing",
                JobDescription = "Junior Marketer",
                EmployeeTypeId = 1
            };
            Employee emp3 = new Employee()
            {
                Id = 3,
                FirstName = "Eleni",
                LastName = "Kallifoni",
                Department = "Logistics",
                JobDescription = "Secretary Associate",
                EmployeeTypeId = 2
            };
            Employee emp4 = new Employee()
            {
                Id = 4,
                FirstName = "Stathis",
                LastName = "Tomaras",
                Department = "Engineers",
                JobDescription = "Structural Engineer",
                EmployeeTypeId = 2
            };
            

            context.Employees.AddOrUpdate(emp1, emp2, emp3, emp4);
            context.SaveChanges();


            #endregion


            base.Seed(context);
        }
    }
}
