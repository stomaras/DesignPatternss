using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static WebAppEmpPortal.Factory.AbstractFactoryy.Enumerations;

namespace WebAppEmpPortal.Factory.AbstractFactoryy
{
    public class Mac : IBrand
    {
        public string GetBrand()
        {
            return Brands.Apple.ToString();
        }
    }
}