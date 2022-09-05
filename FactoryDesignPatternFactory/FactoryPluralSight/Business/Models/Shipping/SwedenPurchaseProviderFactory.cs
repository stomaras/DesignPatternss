using FactoryPluralSight.Business.Models.Commerce;
using FactoryPluralSight.Business.Models.Commerce.Invoice;
using FactoryPluralSight.Business.Models.Commerce.Summary;
using FactoryPluralSight.Business.Models.Shipping.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPluralSight.Business.Models.Shipping
{
    public class SwedenPurchaseProviderFactory : IPurchaseProviderFactory
    {
        public IInvoice CreateInvoice(Order order)
        {
            if (order.Recipient.Country != order.Sender.Country)
            {
                return new NoVATInvoice();
            }
            return new VATInvoice();
        }

        public ShippingProvider CreateShippingProvider(Order order)
        {
            ShippingProviderFactory shippingProviderFactory;

            if (order.Sender.Country != order.Recipient.Country)
            {
                shippingProviderFactory = new ShippingProviderFactory();
            }
            else
            {
                shippingProviderFactory = new ShippingProviderFactory();
            }
        }

        public ISummary CreateSummary(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
