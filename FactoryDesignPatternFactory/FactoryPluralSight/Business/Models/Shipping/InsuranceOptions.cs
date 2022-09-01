using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPluralSight.Business.Models.Shipping
{
    /*
     * Class which provide all Insurance Options
     * 
     */
    public class InsuranceOptions
    {
        public bool ProviderHasInsurance { get; set; }
        public bool ProviderHasExtendedInsurance { get; set; }
        public bool ProviderRequiresReturnOnDamage { get; set; }
    }
}
