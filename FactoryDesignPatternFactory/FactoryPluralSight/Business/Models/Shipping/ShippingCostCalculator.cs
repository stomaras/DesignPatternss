using FactoryPluralSight.Business.Models.Shipping.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPluralSight.Business.Models.Shipping
{
    /*
     * Class About Shipping Cost Calculation
     * with three properties 
     * 1) InternationalShippingFee
     * 2) extraWeightFee
     * 3) ShippingType
     */
    public class ShippingCostCalculator
    {
        private readonly decimal internationalShippingFee;
        private readonly decimal extraWeightFee;

        public ShippingType ShippingType { get; set; }

        public ShippingCostCalculator(decimal intrantionalShippingFee, decimal extraWeightFee, ShippingType shippingType = ShippingType.Standard)
        {
            this.internationalShippingFee = intrantionalShippingFee;
            this.extraWeightFee = extraWeightFee;
            ShippingType = shippingType;
        }

        public decimal CalculateFor(string destinationCountry, string originCountry, decimal weight)
        {

            decimal total = 10m;// default shipping cost

            // plus international shipping
            if (destinationCountry != originCountry)
            {
                total += internationalShippingFee;
            }

            // Calculate Cost For weight over 5kg
            if (weight > 5)
            {
                total += extraWeightFee;
            }

            // Calculate Cost For Shipping Type.
            switch (ShippingType)
            {
                case ShippingType.Standard: total += 20; break;
                case ShippingType.Express: total += 30; break;
                case ShippingType.NextDay: total += 50; break;
                default:
                    break;
            }

            return total;
        }
    }
}
