using FactoryPluralSight.Business.Models.Commerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPluralSight.Business.Models.Shipping
{
    public class AustraliaPostShippingProvider : ShippingProvider
    {
        private readonly string clientId;
        private readonly string secret;

        public AustraliaPostShippingProvider(
            string clientId,
            string secret,
            ShippingCostCalculator shippingCostCalculator,
            CustomHandlingOptions customsHandlingOptions,
            InsuranceOptions insuranceOptions)
        {
            this.clientId = clientId;
            this.secret = secret;

            ShippingCostCalculator = shippingCostCalculator;
            CustomHandlingOptions = customsHandlingOptions;
            InsuranceOptions = insuranceOptions;
        }

        public override string GenerateShippingLabelFor(Order order)
        {
            var shippingId = GetShippingId();

            if (order.Recipient.Country != order.Sender.Country)
            {
                throw new NotSupportedException("International shipping not supported");
            }

            var shippingCost = ShippingCostCalculator.CalculateFor(order.Recipient.Country,
                order.Sender.Country,
                order.TotalWeight);

            return $"Shipping Id: {shippingId} {Environment.NewLine}" +
                    $"To: {order.Recipient.To} {Environment.NewLine}" +
                    $"Order total: {order.Total} {Environment.NewLine}" +
                    $"Tax: {CustomHandlingOptions.TaxOptions} {Environment.NewLine}" +
                    $"Shipping Cost: {shippingCost}";
        }

        private string GetShippingId()
        {
            // Invoke API with API Key

            return $"AUS-{Guid.NewGuid()}";
        }
    }
}
