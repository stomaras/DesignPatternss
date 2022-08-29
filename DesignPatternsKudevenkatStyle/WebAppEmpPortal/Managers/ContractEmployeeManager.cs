using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppEmpPortal.Managers
{
    public class ContractEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 5;
        }

        public decimal GetPay()
        {
            return 12;
        }

        // Specific to contract Employee not implemented in IEmployeeManager
        public decimal GetMedicalAllowance()
        {
            return 100;
        }
    }
}