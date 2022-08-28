using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppEmpPortal.Factory.FactoryMethod
{
    public class EmployeeManagerFactory 
    {
        public BaseEmployeeFactory CreateFactory(Employee emp)
        {
            BaseEmployeeFactory returnValue = null;
            if (emp.EmployeeTypeId == 1)
            {
                returnValue = new ContractEmployeeFactory(emp);
            }
            else if(emp.EmployeeTypeId == 2)
            {
                returnValue = new PermanentEmployeeFactory(emp);
            }
            return returnValue;
        }
    }
}