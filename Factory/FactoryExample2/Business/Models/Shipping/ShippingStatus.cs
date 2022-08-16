using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample2.Business.Models.Shipping
{
    public enum ShippingStatus
    {
        WaitingForPayment,
        ReadyForShippment,
        Shipped
    }
}
