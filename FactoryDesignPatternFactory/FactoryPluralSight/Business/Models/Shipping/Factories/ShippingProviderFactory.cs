using FactoryPluralSight.Business.Models.Shipping.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPluralSight.Business.Models.Shipping.Factories
{
    /*
     * Shipping Provider Factory can be used everywhere makes sense to create an instance of a shipping provider.
     * Our Shopping Cart no longer has to care about the creation of the shipping provider.
     * This means that we seperated the creational process of instantiating that shipping provider into a seperate class.
     * There is a method which create an instance of a shipping provider.. Depends on what parameters you are passed in this method 
     * you may get different variations of the shipping providers.
     * 
     * Simple Factory has all of the implementation and details inside the CreateShippingProvider Mrthod.
     * The Factory Method will also provide a method for retrieving the creation of a shipping provider.
     * This would allow you to either act on what is passed into the creation, or you might want to do additional common interactions 
     * with the result of the creation before it's being passed back into the caller.
     * 
     */
    public class ShippingProviderFactory : GeneralShippingProviderFactory
    {
        public override ShippingProvider CreateShippingProvider(string country)
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
