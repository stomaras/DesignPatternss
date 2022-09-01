using FactoryPluralSight.Business.Models.Commerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPluralSight.Business.Models.Shipping
{
    public abstract class ShippingProvider
    {
        /*
         * Facade
         */
        public ShippingCostCalculator ShippingCostCalculator { get; set; }
        public CustomHandlingOptions CustomHandlingOptions { get; set; }
        public InsuranceOptions InsuranceOptions { get; set; }
        public bool RequireSignature { get; set; }
        public abstract string GenerateShippingLabelFor(Order order);
    }
}
