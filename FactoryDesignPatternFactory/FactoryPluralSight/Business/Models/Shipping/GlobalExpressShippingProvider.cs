using FactoryPluralSight.Business.Models.Commerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPluralSight.Business.Models.Shipping
{
    public class GlobalExpressShippingProvider : ShippingProvider
    {

        /// <summary>
        /// We return a dummy string but obviously in a real-world with a real Shipping Provider , you had propably generate a real id
        /// for that particular order.
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public override string GenerateShippingLabelFor(Order order)
        {
            return "GLOBAL-EXPRESS";
        }
    }
}
