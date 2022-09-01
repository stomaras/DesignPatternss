using FactoryPluralSight.Business.Models.Commerce;
using FactoryPluralSight.Business.Models.Shipping;
using FactoryPluralSight.Business.Models.Shipping.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPluralSight.Business
{
    public class ShoppingCart
    {
        private readonly Order order;

        public ShoppingCart(Order order)
        {
            this.order = order;
        }

        public string Finalize()
        {
            #region Create Shipping Provider
            ShippingProvider shippingProvider;

            if (order.Sender.Country == "Australia")
            {
                #region Australia Post Shipping Provider
                ShippingCostCalculator shippingCostCalculator = new ShippingCostCalculator(intrantionalShippingFee: 250, extraWeightFee: 500)
                {
                    ShippingType = ShippingType.Standard
                };
                #endregion
                var customsHandlingOptions = new CustomHandlingOptions()
                {
                    TaxOptions = TaxOptions.PrePaid
                };

                var insuranceOptions = new InsuranceOptions
                {
                    ProviderHasInsurance = false,
                    ProviderHasExtendedInsurance = false,
                    ProviderRequiresReturnOnDamage = false
                };

                shippingProvider = new AustraliaPostShippingProvider("CLIENT_ID",
                    "SECRET",
                    shippingCostCalculator,
                    customsHandlingOptions,
                    insuranceOptions);
                #endregion
            }
            else if (order.Sender.Country == "Sweden")
            {
                #region Swedish Postal Service Shipping Provider
                var shippingCostCalculator = new ShippingCostCalculator(intrantionalShippingFee: 50, extraWeightFee: 100)
                {
                    ShippingType = ShippingType.Express
                };
                var customHandlingOptions = new CustomHandlingOptions()
                {
                    TaxOptions = TaxOptions.PayOnArrival
                };

                var insuranceOptions = new InsuranceOptions
                {
                    ProviderHasInsurance = true,
                    ProviderHasExtendedInsurance = false,
                    ProviderRequiresReturnOnDamage = false
                };

                shippingProvider = new SwedenPostalServiceShippingProvider("API_KEY", shippingCostCalculator, customHandlingOptions, insuranceOptions);

                #endregion
            }
            else
            {
                throw new NotSupportedException("No Shipping provider founf for origin country");
            }

            order.ShippinStatus = ShippingStatus.ReadyForShippment;

            return shippingProvider.GenerateShippingLabelFor(order);


        }






        }
    }
}
