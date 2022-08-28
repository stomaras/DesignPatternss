using Contexts;
using Repositories.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEmpPortal
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpPortalContext db = new EmpPortalContext();
            UnitOfWork companyUnit = new UnitOfWork(db);



            //var employees = companyUnit.Employees.EmployeesWithTypes();

            //foreach (var item in employees)
            //{
            //    Console.WriteLine("Employees:\n");
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("Employee:\n ");
            //    Console.WriteLine($"With id : {item.Id}, with first name: {item.FirstName}, with last name {item.LastName}, with Job description: {item.JobDescription}, with department {item.Department}, with employee type {item.EmployeeType.Type}");
            //    Console.ResetColor();
            //}
        }
    }
}

/*
 * Factory Design Pattern 
 * 
 * Assume that for permanent employee the early pay $8 bonus is 10%
 * Whereas for contract employee the early pay is $12 with 5% bonus.
 * 
 * Choose Factory Pattern When
 * - The Object needs to be extended to subclasses
 * - The Classes does not know wht exact sub-classes it has to create
 * - The Product implementation tend to change over time and Client remains unchnaged
 * 
 * 1) Simple Factory Pattern.
 * 
 * CLIENT ----> Uses -----> FACTORY ----> Creates -----> PRODUCT
 * -------------------------------------------------------------------------------------------------------
 * -------------------------------------------------------------------------------------------- PERMANENT (1)
 * EMPLOYEE CONTROLLER ---> uses ---> EMPLOYEE MANAGER FACTORY ---> Creates ----> IEMPLOYEE 
 * -------------------------------------------------------------------------------------------- CONTRACT (2)
 * --------------------------------------------------------------------------------------------------------
 * 
 * RECAP SIMPLE FACTORY
 * - Simple Factory abstracts the creation details of the product
 * - Simple Factory refers to the newly created object through an interface
 * - Any new type creation is handed with a change of code in the factory class and not at the client code.
 * 
 * 
 * 2) Factory Method Pattern
 * 
 *              ----------------------------------------------Concrete Creator Product A---------------
 *               Creator
 * CLIENT -----> +Create-------------------------------------------------------------------------------Product
 *               (Abstract)
 *              ----------------------------------------------Concrete Creator Product B---------------
 * 
 * 
 * In Factory Method Pattern the factory replaced with Abstract Concrete Creator which is responsible for 
 *                           creating the concrete product A and concrete product B 
 * 
 * 
 * Business Requirement
 * - Differentiate employees as permanent and contract and segregate their ay scales as well as bonus based on their employee types(Achieved using simple factory)
 * - Calculate Permanent Employee house rent allowance
 * - Claculate Contract Employee medical allowance.
 * 
 * Since the house allowance computation is specific to permanent employee we are not going to add this at the  
 * interface level of IEmployeeManager, instead we are going to write the implementation at the PermanentEmployeeManager class itself.
 * 
 * We are going to provide another layer of abstraction which takes care of computing the common interface operations as well as
 * specific operations related to permanent and contract employee.
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */
