using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppEmpPortal.Managers;

namespace WebAppEmpPortal.Factory.FactoryMethod
{
    public abstract class BaseEmployeeFactory
    {
        protected Employee _emp;
        public BaseEmployeeFactory(Employee emp)
        {
            _emp = emp;
        }

        public Employee ApplySalary()
        {
            IEmployeeManager manager = this.Create();
            _emp.Bonus = manager.GetBonus();
            _emp.HourlyPay = manager.GetPay();
            return _emp;
        }

        public abstract IEmployeeManager Create();
    }
}

/*
 * We have implemented the operation specific to contract and permanent employees
 * in their specific factory method 
 * Next step is to compute the bonus and hourly pay which is common for both 
 * contract and permanent employees.
 * 
 */