using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPluralSight.Business.Models.Shipping.Factories
{
    /*
     * One abstract method , which subclasses is going to override to determine 
     * how the product is created.
     * 
     */
    public abstract class GeneralShippingProviderFactory
    {
        public abstract ShippingProvider CreateShippingProvider(string country);

        /// <summary>
        /// Can now change common things with the ShippingProvider before it's return back to the client,
        /// It can also inject things inside CreateShippingProvider before it's requesting an instantiation 
        /// of the product.
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public ShippingProvider GetShippingProvider(string country)
        {
            var provider = CreateShippingProvider(country);

            if (country == "Sweden" && provider.InsuranceOptions.ProviderHasInsurance)
            {
                provider.RequireSignature = false;
            }

            return provider;
        }
    }
}
