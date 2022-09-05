using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPluralSight.Business.Models.Commerce.Summary
{
    public class CSVSummary : ISummary
    {
        public string CreateOrderSummary(Order order)
        {
            return " This is a CSV Summary";
        }

        public void Send()
        {
            throw new NotImplementedException();
        }
    }
}
