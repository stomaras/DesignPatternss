using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Cards
{
    public class Titanium : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 3000;
        }

        public string GetCardType()
        {
            return "Titanium";
        }

        public int GetCreditLimit()
        {
            return 25000;
        }
    }
}
