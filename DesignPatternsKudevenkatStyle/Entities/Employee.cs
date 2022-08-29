﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobDescription { get; set; }
        public string Department { get; set; }
        public int EmployeeTypeId { get; set; }
        public EmployeeType EmployeeType { get; set; }

        public decimal HourlyPay { get; set; }
        public decimal Bonus { get; set; }

        public decimal HouseAllowance { get; set; }
        public decimal MedicalAllowance { get; set; }

        public string ComputerDetails { get; set; }
    }
}
