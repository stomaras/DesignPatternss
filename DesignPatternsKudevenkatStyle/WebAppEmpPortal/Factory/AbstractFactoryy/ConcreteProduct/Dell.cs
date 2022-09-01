using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppEmpPortal.Factory.AbstractFactoryy
{
    public class Dell : IBrand
    {
        public string GetBrand()
        {
            return Enumerations.Brands.Dell.ToString();
        }
    }
}