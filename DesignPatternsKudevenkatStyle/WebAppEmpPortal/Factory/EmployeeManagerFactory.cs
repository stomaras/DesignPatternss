using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppEmpPortal.Managers;

namespace WebAppEmpPortal.Factory
{
    public class EmployeeManagerFactory
    {
        Func<int, bool> checkContractEmployeeType;
        Func<int, bool> checkPermanentEmployeeType;
        public EmployeeManagerFactory()
        {
            checkContractEmployeeType = CheckValidityOfContractEmployee;
            checkPermanentEmployeeType = CheckValidityOfPermanentEmployee;
        }
        public IEmployeeManager GetEmployeeManager(int employeeTypeID)
        {
           
            IEmployeeManager returnValue = null;
            if (checkContractEmployeeType.Invoke(employeeTypeID))
            {
                returnValue = new ContractEmployeeManager();
            }
            else if (checkPermanentEmployeeType.Invoke(employeeTypeID))
            {
                returnValue = new PermanentEmployeeManager();
            }

            return returnValue;
        }


        #region Methods Which Helps With Delegates
        public bool CheckValidityOfPermanentEmployee(int id)
        {
            if (id == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckValidityOfContractEmployee(int id)
        {
            if (id == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion


    }
}