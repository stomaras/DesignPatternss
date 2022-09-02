using FactoryPluralSight.Business.Models.Shipping.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPluralSight.Business.Models.Shipping
{
    /*
     * Shipping Provider Factory can be used everywhere makes sense to create an instance of a shipping provider.
     * Our Shopping Cart no longer has to care about the creation of the shipping provider.
     * This means that we seperated the creational process of instantiating that shipping provider into a seperate class.
     * 
     */
    public class ShippingProviderFactory
    {
        public static ShippingProvider CreateShippingProvider(string country)
        {
            #region Create Shipping Provider
            ShippingProvider shippingProvider;

            if (country == "Australia")
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

            }
            else if (country == "Sweden")
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

                shippingProvider = new SwedishPostalServiceShippingProvider("API_KEY", shippingCostCalculator, customHandlingOptions, insuranceOptions);

                #endregion
            }
            else
            {
                throw new NotSupportedException("No Shipping provider founf for origin country");
            }
            #endregion
            return shippingProvider;
        }
    }
}
