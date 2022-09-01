using FactoryPluralSight.Business.Models.Commerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPluralSight.Business.Models.Shipping
{
    public class SwedenPostalServiceShippingProvider : ShippingProvider
    {
        private readonly string apiKey;

        public SwedenPostalServiceShippingProvider(
            string apiKey, 
            ShippingCostCalculator shippingCostCalculator,
            CustomHandlingOptions customHandlingOptions,
            InsuranceOptions insuranceOptions)
        {
            this.apiKey = apiKey;
            ShippingCostCalculator = shippingCostCalculator;
            CustomHandlingOptions = customHandlingOptions;
            InsuranceOptions = insuranceOptions;
        }
        public override string GenerateShippingLabelFor(Order order)
        {
            var shippingId = GetShippingId();

            var shippingCost = ShippingCostCalculator.CalculateFor(order.Recipient.Country, order.Sender.Country, order.TotalWeight);

            return $"Shipping Id: {shippingId} {Environment.NewLine}" +
                $"To: {order.Recipient.To} {Environment.NewLine}" +
                $"Order Total: {order.Total} {Environment.NewLine}" +
                $"Tax: {CustomHandlingOptions.TaxOptions} {Environment.NewLine}" +
                $"Shipping Cost: {shippingCost}";
        }

        private string GetShippingId()
        {
            // Invoke API with API Key

            return Guid.NewGuid().ToString();
        }
    }
}
