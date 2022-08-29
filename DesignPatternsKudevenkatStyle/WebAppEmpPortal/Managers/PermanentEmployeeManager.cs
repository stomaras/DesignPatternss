using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppEmpPortal.Managers
{
    public class PermanentEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 10;
        }

        public decimal GetPay()
        {
            return 8;
        }

        // Specific for the PermanentEmployeeManager, not implemented in the IEmployeeManager
        public decimal GetHouseAllowance()
        {
            return 150;
        }
    }
}