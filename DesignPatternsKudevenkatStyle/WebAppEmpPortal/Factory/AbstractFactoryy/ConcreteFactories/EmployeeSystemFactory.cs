using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppEmpPortal.Factory.AbstractFactoryy
{
    public class EmployeeSystemFactory
    {

        public IComputerFactory Create(Employee e)
        {
            IComputerFactory returnValue = null;
            if (e.EmployeeTypeId == 1)
            {
                if (e.JobDescription == "Manager")
                {
                    returnValue = new MACLaptopFactory();
                }
                else
                {
                    returnValue = new MACFactory();
                }
            }
            else if (e.EmployeeTypeId == 2)
            {
                if (e.JobDescription == "Manager")
                {
                    returnValue = new DellLaptopFactory();
                }
                else
                {
                    returnValue = new DellFactory();
                }
            }
            return returnValue;
        }
    }
}